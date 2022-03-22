<?php
session_start();
 require '../dataAccess/DatabaseMediator.php';
 require '../classes/Employee.php';
 $errorMessage = [];
  if(!empty($_POST['username']) && !empty($_POST['password']))
  {
    $username=$_POST['username'];
    $password=$_POST['password'];
   
    $db = new DatabaseMediatior();
    $employee = $db->LogInEmployee( $username, $password );
    if($employee==null){
      $errorMessage= 'There is no user with this username or password!'; 
      header('Location: ../LogInPage.php?error='.$errorMessage);
      exit;
    }
    $employeeId = $employee->getId();
    $_SESSION["employeeId"] = $employeeId;
    if($employee->getPassword()=="0000"){
      $errorMessage= 'You have to change your password.'; 
      header('Location: ../ProfilePage.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
    }
    else{
      header('Location: ../ProfilePage.php?employeeId='. $employeeId);
    }
    
        exit;
  }
  else
  { $errorMessage= 'Make sure all required fields have a value'; 
    header('Location: ../LogInPage.php?error='.$errorMessage);
    exit;
  }
    
    
?>