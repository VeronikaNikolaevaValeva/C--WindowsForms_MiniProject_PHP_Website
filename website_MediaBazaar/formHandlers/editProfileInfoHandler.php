<?php
session_start();
require '../dataAccess/DatabaseMediator.php';
require '../classes/Employee.php';
$db=new DatabaseMediatior();
$errorMessage = [];
$employee=$db->GetEmployee($_SESSION["employeeId"]);
$employeeId=$employee->getId();
$changeUsername;
$changePassword;
$changeFirstName;
$changeLastName;
$changeEmail;
$changeStreet;
$changeHouseNumber;
$changeTown;
$changeCountry;
$changePhone;
$employeeInfo = array();
if(!empty($_POST['changeUsername']))
  {
    $changeUsername=$_POST['changeUsername'];
    $employeeInfo["changeUsername"]=$changeUsername;

  }
  if(!empty($_POST['changeFirstName']))
  {
    $changeFirstName=$_POST['changeFirstName'];
    $employeeInfo["changeFirstName"]=$changeFirstName;
  }
  if(!empty($_POST['changeLastName']))
  {
    $changeLastName=$_POST['changeLastName'];
    $employeeInfo["changeLastName"]=$changeLastName;
  }
  if(!empty($_POST['changePassword']) && !empty($_POST['repeatPassword']) && ($_POST['changePassword'])==($_POST['repeatPassword']) )
  {
    $changePassword=$_POST['changePassword'];
    $employeeInfo["changePassword"]=$changePassword;
  }
  if(!empty($_POST['changeEmail']))
  {
    $changeEmail=$_POST['changeEmail'];
    $employeeInfo["changeEmail"]=$changeEmail;
  }
  if(!empty($_POST['changeStreet']))
  {
    $changeStreet=$_POST['changeStreet'];
    $employeeInfo["changeStreet"]=$changeStreet;
  }
  if(!empty($_POST['changePhone']))
  {
    $changePhone=$_POST['changePhone'];
    $employeeInfo["changePhone"]=$changePhone;
  }
  if(!empty($_POST['changeCountry']))
  {
    $changeCountry=$_POST['changeCountry'];
    $employeeInfo["changeCountry"]=$changeCountry;
  }
  if(!empty($_POST['changeTown']))
  {
    $changeTown=$_POST['changeTown'];
    $employeeInfo["changeTown"]=$changeTown;
  }
  if(!empty($_POST['changeHouseNumber']))
  {
    $changeHouseNumber=$_POST['changeHouseNumber'];
    $employeeInfo["changeHouseNumber"]=$changeHouseNumber;
  }
  if(empty($_POST['changeUsername'])&&empty($_POST['changeNames'])&&empty($_POST['changePassword'])&&empty($_POST['changeEmail'])&&empty($_POST['changeFirstName'])&&empty($_POST['changeLastName'])&&empty($_POST['changeStreet'])&&empty($_POST['changeHouseNumber'])&&empty($_POST['changeTown'])&&empty($_POST['changeCountry'])&&empty($_POST['changePhone']))
  { $errorMessage= 'Make sure all required fields have a value'; 
    header('Location: ../EditProfile.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
    exit;
  }
  if(!empty($_POST['changePassword']) && !empty($_POST['repeatPassword']) && $_POST['changePassword'] != $_POST['repeatPassword'])
  {
     $errorMessage = "Your password does not match!";
     header('Location: ../EditProfile.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
     exit;
  }
  foreach($employeeInfo as $x => $x_value) {
    if($x=="changeUsername"&& $x_value!=""){
      $id = $db->UpdateUsername( $changeUsername, $employeeId);
      $employee->setUsername($changeUsername);
    }else if($x=="changeFirstName"&& $x_value!=""){
      $id = $db->UpdateFirstName($changeFirstName, $employeeId);
      $employee->setFname($changeFirstName);
    }else if($x=="changeLastName"&& $x_value!=""){
        $id = $db->UpdateLastName($changeLastName, $employeeId);
        $employee->setLname($changeLastName);
    }else if($x=="changePassword"&& $x_value!=""){
      $id = $db->UpdatePassword( $changePassword, $employeeId);
      $employee->setPassword($changePassword);
    }else if($x=="changeEmail"&& $x_value!=""){
      $id = $db->UpdateEmail($changeEmail, $employeeId);
      $employee->setEmail($changeEmail);
    }else if($x=="changeStreet"&& $x_value!=""){
        $id = $db->UpdateStreet( $changeStreet, $employeeId);
        $employee->setStreet($changeStreet);
    }else if($x=="changeHouseNumber"&& $x_value!=""){
        $id = $db->UpdateStreetNumber( $changeHouseNumber, $employeeId);
        $employee->setStreetNumber($changeHouseNumber);
    }else if($x=="changeTown"&& $x_value!=""){
        $id = $db->UpdateTown( $changeTown, $employeeId);
        $employee->setTown($changeTown);
    }else if($x=="changeCountry"&& $x_value!=""){
        $id = $db->UpdateCountry( $changeCountry, $employeeId);
        $employee->setCountry($changeCountry);
    }else if($x=="changePhone"&& $x_value!=""){
        $id = $db->UpdatePhone( $changePhone, $employeeId);
        $employee->setPhone($changePhone);
    }
    
  }
  header('Location: ../ProfilePage.php?employeeId='.$_SESSION['employeeId']);
?>