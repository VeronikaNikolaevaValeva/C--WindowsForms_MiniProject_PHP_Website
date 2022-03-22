var daysOfWeek = ["Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"];
var checkedShifts=[];
$(document).ready(function(){
        $('#selectedShifts input:checked').each(function() {
            var dayName=($(this).attr('name')).substr(0, ($(this).attr('name')).indexOf('-'));
            checkedShifts.push(dayName);
        });
        
        if(checkedShifts.length==20){
            for(var i=0;i<daysOfWeek.length;i++){
                $('.'+daysOfWeek[i]).each(function() {
                    if($(this).is(':checked')){
                        $(this).attr("disabled", true);
                    }
                });
            }
        }
        function handleCheckboxClick(dayOfWeekName) {
            $(`.${ dayOfWeekName }`).change(function(){
                    if ($(this).is(':checked')) {
                        checkedShifts.push($(this));
                        if(checkedShifts.length==21){
                            for(var i=0;i<daysOfWeek.length;i++){
                                $('.'+daysOfWeek[i]).each(function() {
                                    if(!$(this).is('disabled')){
                                        $(this).attr("disabled", false);
                                    }
                                });
                            }
                        }
                    }else{
                        checkedShifts.splice(checkedShifts.indexOf($(this)),1);
                        if(checkedShifts.length==20){
                            for(var i=0;i<daysOfWeek.length;i++){
                                $('.'+daysOfWeek[i]).each(function() {
                                    if($(this).is(':checked')){
                                        $(this).attr("disabled", true);
                                    }
                                });
                            }
                        }
                    }
                });
        }
        daysOfWeek.forEach(day => handleCheckboxClick(day));
        
        $( "#submit_availability" ).click(function() {
            for(var i=0;i<daysOfWeek.length;i++){
                $('.'+daysOfWeek[i]).each(function() {
                    if(!$(this).is('disabled')){
                        $(this).attr("disabled", false);
                    }
                });
            }
        });
});