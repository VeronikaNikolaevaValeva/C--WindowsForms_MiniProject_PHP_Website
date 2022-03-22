<?php
session_start();
 require '../dataAccess/DatabaseMediator.php';
 require '../classes/Employee.php';
 require '../classes/Holiday.php';
 $errorMessage = [];
 if(isset($_POST['start_date']) && isset($_POST['end_date']) && $_POST['start_date']!="" && $_POST['end_date']!="")
{
    $db = new DatabaseMediatior();
    $employee=$db->GetEmployee($_SESSION["employeeId"]);
    $employeeId=$employee->getId();
    $start_date=$_POST['start_date'];
    $end_date=$_POST['end_date'];
    $requested_time=date("Y-m-d H:i:s");
    if($db->GetRequestedHoliday($employeeId,$start_date,$end_date)!=null){
        $errorMessage= 'You have already requested a holiday for these days!'; 
        header('Location: ../RequestHoliday.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
        exit;
    }
    if($db->GetHoliday($employeeId,$start_date,$end_date)!=null){
        $errorMessage= 'You already have a registered holiday for these days!'; 
        header('Location: ../RequestHoliday.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
        exit;
    }
    $db->RequestHoliday($employeeId,$start_date,$end_date,$requested_time);
    header('Location: ../RequestHoliday.php?employeeId='.$_SESSION['employeeId']);
    exit;
}
else
{ 
    $errorMessage= 'Please select start and end date!'; 
    header('Location: ../RequestHoliday.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
    exit;
}
        
    
?>