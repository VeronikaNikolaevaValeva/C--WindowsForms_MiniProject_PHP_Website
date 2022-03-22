<?php
class Employee
{
        private $id;
        private $bsn;
        private $fname;
        private $lname;
        private $gender;
        private $email;
        private $username;
        private $password;
        private $birthDay;
        private $addrStreet;
        private $addrStreetNumber;
        private $addrZipcode;
        private $addrTown;
        private $addrCountry;
        private $firstWorkingDay;
        private $emergencyPhoneNumber;
        private $iban;
        private $hourlyWage;
        private $contractStartDate;
        private $contract;
        private $position;
    
    public function __construct(int $id, string $bsn, string $firstName, string $lastName, string $gender, string $email, string $username, string $password, string $birthDay, string $addrStreet
    , string $addrStreetNumber, string $addrZipcode, string $addrTown, string $addrCountry, string $firstWorkingDay, string $emergencyPhoneNumber, string $iban, 
    string $hourlyWage, string $contractStartDate, string $contract, string $position)
    {
        $this->id= $id;
        $this->bsn= $bsn;
        $this->fname = $firstName;
        $this->lname = $lastName;
        $this->gender = $gender;
        $this->email = $email;
        $this->username = $username;
        $this->password = $password;
        $this->birthDay = $birthDay;
        $this->addrStreet = $addrStreet;
        $this->addrStreetNumber = $addrStreetNumber;
        $this->addrZipcode = $addrZipcode;
        $this->addrTown = $addrTown;
        $this->addrCountry = $addrCountry;
        $this->firstWorkingDay = $firstWorkingDay;
        $this->emergencyPhoneNumber = $emergencyPhoneNumber;
        $this->iban = $iban;
        $this->hourlyWage = $hourlyWage;
        $this->contractStartDate = $contractStartDate;
        $this->contract = $contract;
        $this->position = $position;
        
    }

    public function getId()
    {
        return $this->id;
    }public function getBsn()
    {
        return $this->bsn;
    }
    public function getFname()
    {
        return $this->fname;
    }
    public function setFname($fname) {
        $this->fname = $fname;
      }
      public function getLname()
    {
        return $this->lname;
    }
    public function setLname($lname) {
        $this->lname = lname;
      }
    public function getUsername()
    {
        return $this->username;
    }
    public function setUsername($username) {
        $this->username = $username;
      }
    public function getPassword()
    {
        return $this->password;
    }
    public function setPassword($password) {
        $this->password = $password;
      }
    public function getEmail()
    {
        return $this->email;
    }
    public function setEmail($email) {
        $this->email = $email;
      }
      public function getPhone()
    {
        return $this->emergencyPhoneNumber;
    }
    public function setPhone($phone) {
        $this->emergencyPhoneNumber = $phone;
      }
      public function getStreet()
    {
        return $this->addrStreet;
    }
    public function setStreet($street)
    {
        $this->addrStreet = $street;
    }
    public function getStreetNumber()
    {
        return $this->addrStreetNumber ;
    }
    public function setStreetNumber($streetNumber)
    {
        $this->addrStreetNumber = $streetNumber;
    }
    public function getZipcode()
    {
        return $this->addrZipcode ;
    }
    public function getTown()
    {
        return $this->addrTown ;
    }
    public function setTown($town)
    {
        $this->addrTown = $town;
    }
    public function getCountry()
    {
        return $this->addrCountry;
    }
    public function setCountry($country)
    {
        $this->addrCountry = $country;
    }
      public function getIban()
    {
        return $this->iban;
    }
    public function setIban($iban) {
        $this->iban = $iban;
      }
      public function getPosition()
    {
        return $this->position;
    }
    public function getGender()
    {
        return $this->gender;
    }
    public function getContract()
    {
        return $this->contract;
    }
   
}
?>