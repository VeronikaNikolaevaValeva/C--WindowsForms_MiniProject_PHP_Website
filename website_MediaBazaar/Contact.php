<?php
require 'views/Header.php';
$db = new DatabaseMediatior();
$employee = $db->GetEmployee($_GET['employeeId']);
if ($employee->getPosition() != "STORE_WORKER" && $employee->getPosition() != "STOCK_WORKER" && $employee->getPosition() != "CASHIER") {
    session_destroy();
    header('Location: LogInPage.php');
    exit;
} else {
    $position=$employee->GetPosition();
    $email=$db->GetDepartmentByStoreWorker($employee->GetId());
    if($position != "STOCK_WORKER" && $email == null){
        $email=$db->GetStoreManagerEmail();
    }else if($position == "STOCK_WORKER"){
        $email=$db->GetStockManagerEmail();
    }
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
            </div>
            <div class="d-flex flex-lg-row flex-column-reverse">
                <div class="container margin-10px-top margin-10px-bottom">
                <h2 class="margin-10px-top margin-10px-bottom">Contact Your Manager</h2>
                   <?php
                    echo '<form method="post" action="formHandlers/contactHandler.php?employeeId=' . $employee->GetId() . '">';
                    ?>
                    <div>
                        <label for="email">Email</label>
                        <?php
                        echo '<input disabled type="text" id="email" name="email" value="'.$email.'">'
                        ?>
                    </div>
                   
                    <div class="form-group">
                        <label for="message">Message</label>
                        <textarea class="form-control" id="message" rows="10"></textarea>
                    </div>
                    <a><button type="submit" class="btn btn-primary" id="send_email">Send</button></a>
                    </form>

                </div>
            </div>
        </div>

</body>

</html>