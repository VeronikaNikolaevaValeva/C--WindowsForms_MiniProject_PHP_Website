$(document).ready(function(){
 
    $("#start_date").change(function () {
        start_date = new Date($('#start_date').val());
        end_date=new Date($('#end_date').val());
        if(start_date>end_date){
            $('#end_date').val(start_date); 
        }
        start_date_text=$('#start_date').val();
        $('#end_date').attr('min', start_date_text);
    })
    });
    