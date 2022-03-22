<?php
class DatabaseMediatior {
    private $username ='dbi467491';
    private $password ='bulcari';
    private $host ='studmysql01.fhict.local';
    private $dbName ='dbi467491';
    // private $username = 'root';
    // private $password = '';
    // private $host = 'localhost';
    // private $dbName = 'mediabazaar';
    private $conn;

    public function __construct() {
        $this->conn = new PDO("mysql:host=$this->host;dbname=$this->dbName", $this->username, $this->password);
        $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }

    public function GetEmployee(int $id)
    {
        $sql = 'SELECT e.*,ec.contract,ec.startdate,ec.lastdate FROM mb_employee as e inner join mb_employee_contract as ec on e.id=ec.empid WHERE e.id= :id and ec.startdate<now() and ec.lastdate>now()';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $id
        ]);
        if( $sth->rowCount() == 1 )
        {
            $result = $sth->fetch();
            $employee = new Employee($result['id'], $result['bsn'], $result['fname'], $result['lname'], $result['gender'], $result['email'], $result['uname'], $result['pwd']
            , $result['birthdate'], $result['street'], $result['streetnumber'], $result['zipcode'], $result['town'], $result['country'], 
            $result['firstworkingday'], $result['emergphonenumber'], $result['iban'], $result['hourlywage'], $result['startdate'], $result['contract'],
             $result['position']);   
            return $employee;    
        }
        else
        {
            return null;
        }
    }
    public function GetSchedulePerWeek(int $employeeId,string $date)
    {
        $shifts=array();
        $sql = 'SELECT * FROM `mb_shift_with_assigned_employee` WHERE mb_shift_with_assigned_employee.employeeID=:id and week(date, 1) = week(:date, 1);';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $employeeId,
            ':date' => $date
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {
            $shift= new Shift($row['shiftType'],$row['date']);
            array_push($shifts,$shift);
        }
        return $shifts;
    }
    public function GetHolidaysPerEmployeeID(int $employeeId)
    {
        $holidays=array();
        $sql = 'SELECT * FROM `mb_holidays` WHERE employeeID=:id';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $employeeId
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {
            $holiday= new Holiday($row['id'],$row['employeeID'],$row['start_date'],$row['end_date'],date('Y-m-d'));
            array_push($holidays,$holiday);
        }
        return $holidays;
    }
    public function GetAvailabilityPerWeek(int $employeeId,int $week)
    {
        $shifts=array();
        $sql = 'SELECT * FROM mb_employee_availability WHERE mb_employee_availability.employeeID=:id and week(date, 1) = :week;';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $employeeId,
            ':week' => $week
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {
            $shift= new Shift($row['shiftType'],$row['date']);
            array_push($shifts,$shift);
        }
        return $shifts;
    }

    public function LogInEmployee (string $uname, string $pwd)
    {
         $sql = 'SELECT e.*,ec.contract,ec.startdate,ec.lastdate FROM mb_employee as e inner join mb_employee_contract as ec on e.id=ec.empid WHERE uname = :uname AND pwd =:pwd and ec.startdate<now() and ec.lastdate>now();';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':uname' => $uname,
                ':pwd' => $pwd
            ]);
            if( $sth->rowCount() == 1 )
            {
                $result = $sth->fetch();
            $employee = new Employee($result['id'], $result['bsn'], $result['fname'], $result['lname'], $result['gender'], $result['email'], $result['uname'], $result['pwd']
            , $result['birthdate'], $result['street'], $result['streetnumber'], $result['zipcode'], $result['town'], $result['country'], 
            $result['firstworkingday'], $result['emergphonenumber'], $result['iban'], $result['hourlywage'], $result['startdate'], $result['contract'],
             $result['position']);    
            return $employee;    
            }
            else
            {
                return null;
            }
    }

    public function UpdateUsername(string $username, int $id)
    {
        $sql = 'UPDATE mb_employee SET uname = :username WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':username' => $username,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdatePassword(string $password, int $id)
    {
        $sql = 'UPDATE mb_employee SET pwd = :password WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':password' => $password,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateFirstName(string $fname, int $id)
    {
        $sql = 'UPDATE mb_employee SET fname = :fname WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':fname' => $fname,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateLastName(string $lname, int $id)
    {
        $sql = 'UPDATE mb_employee SET lname = :lname WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':lname' => $lname,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateEmail(string $email, int $id)
    {
        $sql = 'UPDATE mb_employee SET email = :email WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':email' => $email,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateStreet(string $street, int $id)
    {
        $sql = 'UPDATE mb_employee SET street = :street WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':street' => $street,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateStreetNumber(string $streetnumber, int $id)
    {
        $sql = 'UPDATE mb_employee SET streetnumber = :streetnumber WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':streetnumber' => $streetnumber,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateTown(string $town, int $id)
    {
        $sql = 'UPDATE mb_employee SET town = :town WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':town' => $town,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateCountry(string $country, int $id)
    {
        $sql = 'UPDATE mb_employee SET country = :country WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':country' => $country,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdatePhone(string $emergphonenumber, int $id)
    {
        $sql = 'UPDATE mb_employee SET emergphonenumber = :emergphonenumber WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':emergphonenumber' => $emergphonenumber,
                ':id' => $id
            ]);
            
            return null;
    }
    public function AddShift(Shift $shift)
    {
        $sql = 'INSERT INTO `mb_shift`(`shiftType`, `date`,`assignableEmployees`) VALUES (:shiftType,:shiftDate,:assignableEmployees) on duplicate key update assignableEmployees=:assignableEmployees';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':assignableEmployees' => $shift->getAssignableEmployees()
            ]);
            
            return null;
    }

    public function AddAvailability(Shift $shift, int $id)
    {
        $sql = 'INSERT INTO `mb_employee_availability`(`employeeID`, `shiftType`, `date`) VALUES (:id,:shiftType,:shiftDate) on duplicate key update employeeID=:id,shiftType=:shiftType, `date`=:shiftDate;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':id' => $id
            ]);
            
            return null;
    }
    public function DeleteAvailability(Shift $shift, int $id)
    {
        $sql = 'DELETE FROM `mb_employee_availability` WHERE employeeID=:id and shiftType=:shiftType and date=:shiftDate';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':id' => $id
            ]);
            
            return null;
    }
    public function RequestHoliday(int $employeeId, string $start_date,string $end_date,string $requested_time)
    {
        $sql = 'INSERT INTO `mb_holiday_request`(`id`,`employeeID`, `start_date`, `end_date`, `requested_date`) VALUES (id,:employeeId,:start_date,:end_date,:requested_time)';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':employeeId' => $employeeId,
                ':start_date' => $start_date,
                ':end_date' => $end_date,
                ':requested_time' => $requested_time
            ]);
            
            return null;
    }
    public function GetRequestedHoliday(int $employeeId, string $start_date,string $end_date)
    {
        $sql = 'SELECT * FROM `mb_holiday_request` where employeeID=:employeeId and start_date=:start_date and end_date=:end_date';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':employeeId' => $employeeId,
            ':start_date' => $start_date,
            ':end_date' => $end_date,
        ]);
        if( $sth->rowCount() == 1 )
        {
            $result = $sth->fetch();
            $holiday = new Holiday($result['id'],$result['employeeID'],$result['start_date'],$result['end_date'],$result['requested_date']);
            return $holiday;
        }else {
            return null;
        }
    }
    public function GetHoliday(int $employeeId, string $start_date,string $end_date)
    {
        $sql = 'SELECT * FROM `mb_holidays` where employeeID=:employeeId and start_date<=:start_date and end_date>=:end_date';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':employeeId' => $employeeId,
            ':start_date' => $start_date,
            ':end_date' => $end_date,
        ]);
        if( $sth->rowCount() == 1 )
        {
            $result = $sth->fetch();
            return 1;
        }else {
            return null;
        }
    }
    public function GetAllRequestedHolidays()
    {
        $holidays=array();
        $sql = 'SELECT * FROM  mb_holiday_request';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {   
            $holiday = new Holiday($row['id'],$row['employeeID'],$row['start_date'],$row['end_date'],$row['requested_date']);
            array_push($holidays,$holiday);
        }
        return $holidays;
    }
    public function GetDepartmentByStoreWorker(int $employeeId)
    {
        $sql = 'SELECT e.email FROM mb_department_dmanager as d inner join mb_employee e on d.dmanager_id=e.id where dept_code in (SELECT dept_code from mb_department_storeworker ds where ds.storeworker_id=:employeeId )';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':employeeId' => $employeeId
        ]);
        if( $sth->rowCount() == 1 )
        {
            $result = $sth->fetch();
            return $result['email'];
        }else {
            return null;
        }
    }
    public function GetStoreManagerEmail()
    {
        $sql = 'SELECT email FROM `mb_employee` WHERE position="STORE_MANAGER"';
        $sth = $this->conn->prepare($sql);
        $sth->execute();
        if( $sth->rowCount() > 0 )
        {
            $result = $sth->fetch();
            return $result['email'];
        }else {
            return null;
        }
    }
    public function GetStockManagerEmail()
    {
        $sql = 'SELECT email FROM `mb_employee` WHERE position="STOCK_WORKER"';
        $sth = $this->conn->prepare($sql);
        $sth->execute();
        if( $sth->rowCount() > 0 )
        {
            $result = $sth->fetch();
            return $result['email'];
        }else {
            return null;
        }
    }
}
?>