<?php
session_start();
 require '../dataAccess/DatabaseMediator.php';
 require '../classes/Employee.php';
 require '../classes/Holiday.php';
 $errorMessage = [];
 $db = new DatabaseMediatior();
 if(isset($_GET['message'])&& $_POST['message']!="")
 {
         $employee=$db->GetEmployee($_SESSION["employeeId"]);
         $to = $_POST['email'];
         $subject = 'Message from '.$employee->getFname().' - BSN: '.$employee->getBsn();
         
         $message =  $_POST['message'];
         
         $header = 'From: '.$employee->getEmail().'';
         
         $retval = mail ($to,$subject,$message,$header);
         
         if( $retval == true ) {
            header('Location: ../Contact.php?employeeId='.$_SESSION['employeeId']);
            exit;
         }else {
            $errorMessage= 'Message cannot be sent!'; 
            header('Location: ../Contact.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
         }
      }
      else{
         $errorMessage= 'Please enter a valid mail!'; 
         header('Location: ../Contact.php?employeeId='.$_SESSION['employeeId'].'&error='.$errorMessage);
         exit;
      }       
    
?>