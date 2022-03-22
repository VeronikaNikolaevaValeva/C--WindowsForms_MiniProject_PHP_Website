<?php
session_start();
 require '../dataAccess/DatabaseMediator.php';
 require '../classes/Employee.php';
 require '../classes/Shift.php';
 $errorMessage = [];
 if(isset($_GET['week'])&& is_numeric($_GET['week']))
{
    
    $week=($_GET['week']);
    $db = new DatabaseMediatior();
    $employee=$db->GetEmployee($_SESSION["employeeId"]);
    $employeeId=$employee->getId();
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

    $markedShifts=0;
    for($i=0;$i<count($daysOfWeek);$i++){
        for($j=0;$j<count($defaultShifts);$j++){
            if(isset($_POST[($daysOfWeek[$i]->format('l')).'-'.$defaultShifts[$j]])){
                $markedShifts++;
            }
        }
    }
    if(($markedShifts<10 && $employee->getContract()=="FULLTIME")||($markedShifts<8 && $employee->getContract()=="EIGHTYPERCENT")){
        $errorMessage= 'Please select at least the minimum amount of shifts depending on your contract!'; 
        header('Location: ../Availability.php?employeeId='.$_SESSION['employeeId'].'&week='.$week.'&error='.$errorMessage);
        exit;
    }

    
    for($i=0;$i<count($daysOfWeek);$i++){
        for($j=0;$j<count($defaultShifts);$j++){
            $newShift=new Shift($defaultShifts[$j],$daysOfWeek[$i]->format('Y-m-d'));
            if(isset($_POST[($daysOfWeek[$i]->format('l')).'-'.$defaultShifts[$j]])){
                $db->AddShift($newShift);
                $db->AddAvailability($newShift,$employeeId);
            }else{
                $db->DeleteAvailability($newShift,$employeeId);
            }
        }
    }
    header('Location: ../Availability.php?employeeId='.$_SESSION['employeeId']);
}
else
{ 
    $errorMessage= 'Please select a week!'; 
    header('Location: ../Availability.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
    exit;
}
        
    
?>