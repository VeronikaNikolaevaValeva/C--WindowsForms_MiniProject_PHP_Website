<?php
require 'views/Header.php';
$db=new DatabaseMediatior();
$employee;
$employeeId; 
$employee=$db->GetEmployee($_SESSION["employeeId"]);
  $employeeId=$employee->getId();
    $fname = $employee->getFname();
    $lname = $employee->getLname();
    $email = $employee->getEmail();
    $username = $employee->getUsername();
    $street = $employee->getStreet();
    $streetNum = $employee->getStreetNumber();
    $zipcode = $employee->getZipcode();
    $town = $employee->getTown();
    $country = $employee->getCountry();
    $phone = $employee->getPhone();
    $picture="other_.png";
if($employee->getGender()=="MALE"){
    $picture="male.png";
}else if($employee->getGender()=="FEMALE"){
    $picture="female.png";
}
?>
<!doctype html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="windows-1252" /> 
        <meta charset="UTF-8">
        <link href="style/ProfilePageStyle.css"   type="text/css"   rel="stylesheet">
        <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"   type="text/css"   rel="stylesheet">
       <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script> 
       <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head> 
<body>
<div class="container px-4 py-5 mx-auto">
    <div class="card card0">
        <div class="d-flex flex-lg-row flex-column-reverse">
            <div class="card card1">
                <div class="row justify-content-center my-auto">
                    <div class="col-md-8 col-10 my-5">
                    <?php
                    echo
                    '<img src="photos/'.$picture.'" alt="profilePicture">';
                    if (isset($_GET['error'])) {
                    $error = $_GET['error'];
                    echo '<div class ="alert alert-primary" role="alert"> Error occured: ' . $error . '</div>';
                     }
                    ?>
                    </div>
                </div>
                
            </div>
            <div class="card card2">
                <div class="my-auto mx-md-5 px-md-5 right">
                    <div class="row justify-content-center px-3 mb-3"> </div>
                        <h3 class="mb-5 text-center heading">Edit account information</h3>
                        
                        <form  method="post" action = "formHandlers/editProfileInfoHandler.php?employeeId=">
                        <div class="form-group"> <label class="form-control-label text-muted">Change username: </label> <input type="text" id="username" name="changeUsername" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change password: </label> <input type="password" id="password" name="changePassword" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Repeat password: </label> <input type="password" id="password" name="repeatPassword" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change first name: </label> <input type="text" id="username" name="changeFirstName" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change last name: </label> <input type="text" id="username" name="changeLastName" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change email: </label> <input type="text" id="username" name="changeEmail" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change street addres: </label> <input type="text" id="username" name="changeStreet" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change house number: </label> <input type="text" id="username" name="changeHouseNumber" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change town: </label> <input type="text" id="username" name="changeTown" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change country: </label> <input type="text" id="username" name="changeCountry" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Change phone number: </label> <input type="text" id="username" name="changePhone" class="form-control"> </div>
                        <div class="row justify-content-center my-3 px-3"> <a><button class="btn-block btn-color" >Save information</button></a> </div>
                        </form>
                </div>
            </div>
        </div>
    </div>
</div>

</body>
</html>