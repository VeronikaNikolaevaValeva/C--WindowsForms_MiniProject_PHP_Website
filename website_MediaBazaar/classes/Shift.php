<?php
class Shift
{
        private $type;
        private $date;
        private $assignableEmployees;
       
    public function __construct(string $type, string $date)
    {
        $this->type= $type;
        $this->date= $date;
        $time=strtotime($date);
        $time1=getdate($time);
        if (($type == "Morning" || $type == "Night") && ($time1['weekday'] != "Friday" && $time1['weekday'] != "Saturday" && $time1['weekday'] != "Sunday"))
            {
                $this->assignableEmployees = 5;
            }
        else
            {
                $this->assignableEmployees = 10;
            }
    }

    public function getType()
    {
        return $this->type;
    }
    public function getDate()
    {
        return $this->date;
    }
    public function getAssignableEmployees()
    {
        return $this->assignableEmployees;
    }
    
    
}
?>