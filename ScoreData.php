<?php
    $servername = "localhost";
    $server_username = "root";
    $password = "";
    $dbName = "ZombieDatabase";

    //Variable from user
    $username = $_POST["usernamePost"]; //"UserTest3";
    $score = $_POST["scorePost"]; //"1";

    //Make connection
    $conn = new mysqli($servername, $server_username, $password, $dbName);
    //Check Connection
    if(!$conn) {
        die("Connection Failed. ". mysqli_connect_error());
    }
    //else echo("Connection Successful")
    
    //Grabbing data
    $sql = "SELECT ID, NAME, SCORE FROM Highscore";
    $result = mysqli_query($conn ,$sql);

    if(mysqli_num_rows($result) > 0) {
        //show data for each row
        while($row = mysqli_fetch_assoc($result)) {
            echo "ID:".$row['ID'] . "|Name:".$row['NAME'] . "|Score:".$row['SCORE'] . ";"; }
    }
    
    //Sending data
    $sql = "INSERT INTO Highscore (NAME, SCORE)
            VALUES ('".$username."','".$score."')";
    $insertResult = mysqli_query($conn ,$sql);

    if(!insertResult) echo "there was an error";
    else echo "Everything ok";
    
    
?>