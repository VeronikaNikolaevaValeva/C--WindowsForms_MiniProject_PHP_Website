<?php
class Holiday
{
        private $id;
        private $employeeId;
        private $start_date;
        private $end_date;
        private $requested_time;
       
    public function __construct(int $id, int $employeeId, string $start_date, string $end_date,string $requested_time)
    {
        $this->$id=$id;
        $this->employeeId= $employeeId;
        $this->start_date= new DateTime($start_date);
        $this->end_date= new DateTime($end_date);
        $this->requested_time= $requested_time;
    }
    public function getId()
    {
        return $this->id;
    }
    public function getEmployeeId()
    {
        return $this->employeeId;
    }
    public function getStartDate()
    {

        return $this->start_date;
    }
    public function getEndDate()
    {
        return $this->end_date;
    }
    public function getRequestedTime()
    {
        return $this->requested_time;
    }
    
    
}
?>