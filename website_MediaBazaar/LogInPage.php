<?php
 if(isset($_GET['error'])) 
 {
   $error=$_GET['error'];   
 }

?>
<!doctype html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="windows-1252" /> 
        <meta charset="UTF-8">
        <link href="style/LogInHeader.css"   type="text/css"   rel="stylesheet">
        <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"   type="text/css"   rel="stylesheet">
       <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script> 
       <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
        
</head> 
<header>

</header>
<body>
<div class="container px-4 py-5 mx-auto">
    <div class="card card0">
        <div class="d-flex flex-lg-row flex-column-reverse">
            <div class="card card1">
                <div class="row justify-content-center my-auto">
                    <div class="col-md-8 col-10 my-5">
                        <div class="row justify-content-center px-3 mb-3"> </div>
                        <h3 class="mb-5 text-center heading">Log in</h3>
                        <h6 class="msg-info">Please login to your account</h6>
                        <form  method="post" action = "formHandlers/loginHandler.php">
                        <div class="form-group"> <label class="form-control-label text-muted">Username: </label> <input type="text" id="username" name="username" class="form-control"> </div>
                        <div class="form-group"> <label class="form-control-label text-muted">Password: </label> <input type="password" id="password" name="password" class="form-control"> </div>
                        <div class="row justify-content-center my-3 px-3"> <a><button class="btn-block btn-color" >Login to Media Bazaar</button></a> </div>
                        </form>
                        <div class="row justify-content-center my-2"> <a href="#"><small class="text-muted">Forgot Password?</small></a> </div>
                    </div>
                </div>
                
            </div>
            <div class="card card2">
                <div class="my-auto mx-md-5 px-md-5 right">
                    <h3 class="text-white">Media Bazaar</h3> <small class="text-white">This website is for the employees of Media Bazaar!</small>
                    <br>
                    <?php
                     if(isset($_GET['error'])) {
                        $error=$_GET['error'];
                    echo '<div class ="alert alert-primary" role="alert"> Error occured: '.$error.'</div>';
                        }
                ?>
                </div>
            </div>
        </div>
    </div>
</div>


</body>
</html>