<?php
require 'views/Header.php';
$db=new DatabaseMediatior();
$employee=$db->GetEmployee($_GET['employeeId']);
if(!is_numeric($_GET['week'])||($employee->getPosition()!="STORE_WORKER" && $employee->getPosition()!="STOCK_WORKER" && $employee->getPosition()!="CASHIER")){
  session_destroy();  
  header('Location: LogInPage.php');
  exit;
}
else{
    $week = $_GET['week'];
    $weekStart=new DateTime();
    $year=new DateTime(date("Y-m-d"));
    $weekStart->setISODate($year->format("Y"),$week);
    $weekEnd=clone $weekStart;
    $weekEnd->modify('+7 days');
    $period = new DatePeriod($weekStart, DateInterval::createFromDateString('1 day'), $weekEnd);
    $daysOfWeek=array();
    foreach($period as $date){
        array_push($daysOfWeek,$date);
    }
    $defaultShifts=['Morning','Afternoon','Evening','Night'];
    $schedule=$db->GetSchedulePerWeek($employee->getId(),$date->format("Y-m-d"));
    $holidays=$db->GetHolidaysPerEmployeeID($employee->getId());
}
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="style/ScheduleStyle.css" type="text/css" rel="stylesheet">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    
    
</head> 
<body>
<div class="container px-4 py-5 mx-auto">
    <div>   
    <?php
    echo '<a href="Schedule.php?employeeId='.$employee->getId().'&week='.($week-1).'"><button type="button" class="btn btn-primary margin-10px-bottom"><</button></a>
    <a href="Schedule.php?employeeId='.$employee->getId().'&week='.($week+1).'"><button type="button" class="btn btn-primary margin-10px-bottom">></button></a>
    <h5>'.$daysOfWeek[0]->format('d-m-Y').' - '.$daysOfWeek[6]->format('d-m-Y').'</h5>'
    ?>
    </div>
    <div class="card card0">
        <div class="d-flex flex-lg-row flex-column-reverse">
        <div class="container">
                <div class="table-responsive margin-10px-top">
                    <table class="table table-bordered text-center">
                        <thead>
                            <tr class="bg-light-gray">
                                <th class="text-uppercase ">Shift
                                </th>
                                <?php
                                for($i=0;$i<7;$i++){
                                    echo 
                                    '<th class="text-uppercase">
                                        <span class="padding-5px-tb padding-15px-lr margin-10px-top margin-10px-bottom ">'.$daysOfWeek[$i]->format('D').'</span>
                                        <div class="margin-10px-top text-light-gray">'.$daysOfWeek[$i]->format('d-m-Y').'</div>
                                    </th>';
                                }
                                
                                ?>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                                for($i=0;$i<4;$i++){
                                    echo 
                                    '<tr>
                                         <td class="align-middle">'.$defaultShifts[$i].'</td>';
                                            for($j=0;$j<7;$j++){
                                                echo '<td class="cell">';
                                                foreach($schedule as $shift){
                                                    if($shift->getType()==$defaultShifts[$i]&&$shift->getDate()==$daysOfWeek[$j]->format('Y-m-d')){
                                                            echo
                                                            '<span class="bg-blue padding-5px-tb padding-15px-lr border-radius-5 margin-10px-top margin-10px-bottom text-white font-size16 xs-font-size13">Assigned</span>';
                                                            
                                                            switch($defaultShifts[$i]){
                                                                case "Morning":{
                                                                    echo '<div class="margin-10px-top text-light-gray">08:00-12:00</div>';
                                                                }break;
                                                                case "Afternoon":{
                                                                    echo '<div class="margin-10px-top text-light-gray">12:00-16:00</div>';
                                                                }break;
                                                                case "Evening":{
                                                                    echo '<div class="margin-10px-top text-light-gray">16:00-1:00</div>';
                                                                }break;
                                                                case "Night":{
                                                                    echo '<div class="margin-10px-top text-light-gray">9:00-10:00</div>';
                                                                }break;
                                                            }        
                                                    }
                                                }
                                                
                                                foreach($holidays as $holiday){
                                                    if($daysOfWeek[$j]>=$holiday->getStartDate()&&$daysOfWeek[$j]<=$holiday->getEndDate()){
                                                        echo
                                                        '<span class="bg-green padding-5px-tb padding-15px-lr border-radius-5 margin-10px-top margin-10px-bottom text-white font-size16 xs-font-size13">Holiday</span>';
                                                    }
                                                }

                                                echo '</td>';
                                                    
                                            }
                                    echo
                                    '</tr>';  
                                }     
                                           
                            ?>
                                                   
                        </tbody>
                    </table>
                </div>
            </div>
            
        </div>
    </div>
</div>

</body>
</html>