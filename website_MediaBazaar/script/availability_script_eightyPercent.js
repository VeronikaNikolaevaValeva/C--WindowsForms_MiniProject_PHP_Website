var daysOfWeek = ["Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"];
var arrDays={};
var arrDaysWithLessShifts=[];
var checkedShifts=[];
var counterOfDaysWithZeroShifts=0;
$(document).ready(function(){
        $('#selectedShifts input:checked').each(function() {
            var dayName=($(this).attr('name')).substr(0, ($(this).attr('name')).indexOf('-'));
            checkedShifts.push(dayName);
        });
        for (var i=0;i<daysOfWeek.length;i++) {
            var currentDaySelectedShifts=0;
            for(var j=0;j<checkedShifts.length;j++){
                if(checkedShifts[j]==daysOfWeek[i]){
                    currentDaySelectedShifts++;
                }
            }
            arrDays[daysOfWeek[i]]=currentDaySelectedShifts;
            if(currentDaySelectedShifts<2){
                arrDaysWithLessShifts.push(daysOfWeek[i]);     
            }
            if(currentDaySelectedShifts==0){
                counterOfDaysWithZeroShifts++;
            }
        }
        handlerCheckSubmittedData();
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
        function handlerCheckSubmittedData(){
            if(arrDaysWithLessShifts.length==4){
                for(var i=0;i<daysOfWeek.length;i++){
                    $('.'+daysOfWeek[i]).each(function() {
                        if($(this).is(':checked') && arrDays[daysOfWeek[i]]==2){
                            $(this).attr("disabled", true);
                        }
                    });
                }                    
            }
            if(counterOfDaysWithZeroShifts==2){
                for(var i=0;i<daysOfWeek.length;i++){
                    $('.'+daysOfWeek[i]).each(function() {
                        if($(this).is(':checked') && arrDays[daysOfWeek[i]]==1){
                            $(this).attr("disabled", true);
                        }
                    });
                }
            }
        }
        function handleCheckboxClick(dayOfWeekName) {
            $(`.${ dayOfWeekName }`).change(function(){
                if ($(this).is(':checked')) {
                    arrDays[dayOfWeekName]++;
                    if(arrDaysWithLessShifts.includes(dayOfWeekName) && arrDays[dayOfWeekName]==2){
                        arrDaysWithLessShifts.splice(arrDaysWithLessShifts.indexOf(dayOfWeekName),1);
                        
                    }
                    if(arrDays[dayOfWeekName]==1){
                        counterOfDaysWithZeroShifts--;
                    }
                    for(var i=0;i<daysOfWeek.length;i++){
                            $('.'+daysOfWeek[i]).each(function() {
                                if(!$(this).is('disabled')){
                                    $(this).attr("disabled", false);
                                }
                            });
                    }
                }else{
                    arrDays[dayOfWeekName]--;
                    if(arrDays[dayOfWeekName]==0){
                        counterOfDaysWithZeroShifts++;
                    }
                    if(!arrDaysWithLessShifts.includes(dayOfWeekName) && arrDays[dayOfWeekName]<2){
                        arrDaysWithLessShifts.push(dayOfWeekName);
                    }
                }
                handlerCheckSubmittedData();
                });
        }
    });