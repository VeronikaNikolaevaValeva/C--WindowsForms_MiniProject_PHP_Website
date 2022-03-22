<?php
require 'views/Header.php';
$db = new DatabaseMediatior();
$employee = $db->GetEmployee($_GET['employeeId']);
if ($employee->getPosition() != "STORE_WORKER" && $employee->getPosition() != "STOCK_WORKER" && $employee->getPosition() != "CASHIER") {
    session_destroy();
    header('Location: LogInPage.php');
    exit;
} else {
    $todaysDate=date('Y-m-d', strtotime('+2 Weeks'));
}
?>
<!doctype html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="style/Availability.css" type="text/css" rel="stylesheet">
    <link href="style/Request_holiday.css" type="text/css" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="script/request_holiday.js"></script>
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
                <p>Approval for holiday requests is subject to the discretion and agreement of your manager. You may be asked to change your requested dates if too many people have already asked for that time off, or if your absence will be to the detriment to the company at that particular time. You should not make travel bookings until approval has been given.</p>
                <p>Please give as much notice as possible of holiday requests. At a minimum we require you to give the company 2 weeks notice, so that we can plan for your absence.</p>
                <p>Please book off holiday days well in advance and in the usual way.</p>
                
            </div>
            <div class="d-flex flex-lg-row flex-column-reverse">
                <div class="container margin-10px-top margin-10px-bottom">
                   
                    <?php
                    echo '<form method="post" action="formHandlers/requestHolidayHandler.php">';
                    ?>
                    <div class="form-group col-md-6">
                        <div class="form-check form-check-inline">
                            <label class="form-check-input width-200" for="start_date">Start date:</label>
                            <?php echo '<input class="form-check-label width-200" type="date" min="'.$todaysDate.'" id="start_date" name="start_date">'; ?>
                        </div>
                        <div class="form-check form-check-inline">
                            <label class="form-check-input width-200" for="end_date">End date:</label>
                            <input class="form-check-label width-200" type="date" min="" id="end_date" name="end_date">
                        </div>
                    </div>
                    <a><button type="submit" class="btn btn-primary" id="request_holiday">Request Holiday</button></a>
                    </form>

                </div>
            </div>
        </div>

</body>

</html>