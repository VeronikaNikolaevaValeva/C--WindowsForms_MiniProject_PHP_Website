<?php
require 'views/Header.php';
$db = new DatabaseMediatior();
$employee = $db->GetEmployee($_GET['employeeId']);
if ($employee->getPosition() != "STORE_WORKER" && $employee->getPosition() != "STOCK_WORKER" && $employee->getPosition() != "CASHIER") {
    session_destroy();
    header('Location: LogInPage.php');
    exit;
} else {
    $shifts = array();
    $week=null;
    if (isset($_GET['week']) && is_numeric($_GET['week']) && $_GET['week']<=($date->format("W")) + 6 && $_GET['week']>=($date->format("W")) + 2) {
        $week = $_GET["week"];
        $shifts = $db->GetAvailabilityPerWeek($employee->getId(), $week);
    }
    $weeks=array();
    for ($i = (($date->format("W")) + 2); $i <= (($date->format("W")) + 6); $i++) {
        $weekStart=new DateTime();
        $year=new DateTime(date("Y-m-d"));
        $weekStart->setISODate($year->format("Y"),$i);
        $weekEnd=clone $weekStart;
        $weekEnd->modify('+7 days');
        array_push($weeks,array('weekNumber' => $i, 'weekStart' => $weekStart->format('d/m/Y'),'weekEnd' => $weekEnd->format('d/m/Y')));
    }
    $daysOfWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
    $defaultShifts = ['Morning', 'Afternoon', 'Evening', 'Night'];
    $status = 0;
}
?>
<!doctype html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="style/Availability.css" type="text/css" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <?php
    if($employee->getContract()=="FLEX"){
        echo '<script src="script/availability_script_flex.js"></script>';
    }else if($employee->getContract()=="FULLTIME"){
        echo '<script src="script/availability_script_fulltime.js"></script>';
    }else if($employee->getContract()=="EIGHTYPERCENT"){
        echo '<script src="script/availability_script_eightyPercent.js"></script>';
    }
    
    ?>
</head>

<body>
    <div class="container px-4 py-5 mx-auto">
        <div>
        </div>
        <div class="card card0">
            <div class="margin-10px-top">
                <?php
                if (isset($_GET['error'])) {
                    $error = $_GET['error'];
                    echo '<div class ="alert alert-primary" role="alert"> Error occured: ' . $error . '</div>';
                }
                ?>
                <p>Hi colleague!</p>
                <p>With this form you state on a weekly basis which days you are available to work. It is important that you always fill in the form on time. This way we can make a good planning and ensure that you get as many services as possible.</p>
                <p class="bold"> When do I have to fill in the form? </p>
                <p>You can fill in the form up to 6 weeks in advance, but the sooner the better. The deadline is always a maximum of 1 week in advance. Example: you submit your availability for week 3 before week 2 starts, so before Sunday 23:59 in week 1. </p>
                <ul>
                    <li>If you have full contract - mark <b>at least 10</b> available shifts (at least 5 days with 2 shifts each day)</li>
                    <li>If you have 80% contract - mark <b>at least 8</b> available shifts (at least 3 days with 2 shifts each day and 2 days with 1 shift)</li>
                </ul>
            </div>
            <div class="d-flex flex-lg-row flex-column-reverse">
                <div class="container margin-10px-top margin-10px-bottom">
                   
                    <?php
                    if(isset($week)){
                        for($i=0;$i<count($weeks);$i++){
                            if($weeks[$i]['weekNumber']==$week){
                                echo '<h5 class="bold margin-10px-top margin-10px-bottom">' . $weeks[$i]['weekStart'] . ' - '.$weeks[$i]['weekEnd'] . '</h5>';
                                
                            }
                        
                        }
                    }
                    echo '<form method="post" action="formHandlers/availabilityHandler.php?week=' . $week . '">';
                    ?>
                     <div class="btn-group">
                        <button type="button" value="week" class="btn btn-primary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Week
                        </button>
                        <div class="dropdown-menu">
                            <?php
                            foreach($weeks as $weekRange) {
                                echo '<a value="week" class="dropdown-item" href="Availability.php?employeeId=' . $_SESSION['employeeId'] . '&week=' . $weekRange['weekNumber']. '">' . $weekRange['weekStart'] . ' - '.$weekRange['weekEnd'].'</a>';
                            }
                            ?>
                        </div>
                    </div>
                    <?php
                    if($week!=null){
                        echo '
                    <div class="form-group col-md-6" id="selectedShifts">';
                        for ($i = 0; $i < 7; $i++) {
                            echo '<h6 class="bold margin-10px-top">' . $daysOfWeek[$i] . '</h6>';
                            for ($j = 0; $j < count($defaultShifts); $j++) {
                                if(count($shifts)==0){
                                    echo '<div class="form-check form-check-inline">
                                    <input class="form-check-input '.$daysOfWeek[$i].'" type="checkbox" name="' . $daysOfWeek[$i] . '-' . $defaultShifts[$j] . '" checked>
                                    <label class="form-check-label" for="inlineCheckbox1">'.$defaultShifts[$j] . '</label></div>';
                                }else{
                                    foreach ($shifts as $shift) {
                                        if ($shift->getType() == $defaultShifts[$j] && getdate(strtotime($shift->getDate()))['weekday'] == $daysOfWeek[$i]) {
                                            $status = 1;
                                            echo
                                            '<div class="form-check form-check-inline">
                                        
                                        <input class="form-check-input '.$daysOfWeek[$i].'" type="checkbox" name="' . $daysOfWeek[$i] . '-' . $defaultShifts[$j] . '" checked>
                                        <label class="form-check-label" for="inlineCheckbox1">' . $shift->getType() . '</label></div>';
                                        }
                                    }
                                    if ($status == 0) {
                                        echo '<div class="form-check form-check-inline">
                                
                                <input class="form-check-input '.$daysOfWeek[$i].'" type="checkbox" name="' . $daysOfWeek[$i] . '-' . $defaultShifts[$j] . '">
                                <label class="form-check-label" for="inlineCheckbox1">' . $defaultShifts[$j] . '</label></div>';
                                    }
                                    $status = 0;
                                }
                            }
                        }echo'
                    </div>
                    <a><button type="submit" class="btn btn-primary" id="submit_availability">Submit</button></a>';
                    }
                    ?>
                    </form>

                </div>
            </div>
        </div>

</body>

</html>