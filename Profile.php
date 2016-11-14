<?php
    $servername = "";
    $username = "id162193_homeworkappteam";
    $password = "password";
    $dbName = "id162193_homeworkapp";

    $insert_username = $_POST["usernamePost"];

    $usernametest = "nasaiwai";
    $conn = new mysqli($servername, $username, $password, $dbName);

    if(!$conn) {
        die("connection failed ".mysqli_connect_error());
    } else {
        echo "connect success";
    }

    $sql = "SELECT * FROM homeworkApp WHERE username = '$insert_username'";
    
    $result = mysqli_query($conn, $sql);

    if(mysqli_num_rows($result)>0) {
        while($row = mysqli_fetch_assoc($result)){
            echo "username:" . $row['username'] .
                 "|firstName:" . $row['firstName'] .
                 "|grade:" . $row['grade'] .
                 "|gender:" . $row['gender'] .
                 "|stageLevel:" . $row['stageLevel'] .
                 "|point:" . $row['point'] .
                 "|streak:" . $row['streak'] .
                 "|profileImage:" . $row['profileImage'] . ";";
        }
    }
    else {
        echo "failed";
    }   
?>
