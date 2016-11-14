<?php
    $servername = "";
    $username = "id162193_homeworkappteam";
    $password = "password";
    $dbName = "id162193_homeworkapp";

    $insert_username = $_POST["usernamePost"];
    $insert_points = $_POST["pointsPost"];
    $insert_streak = $_POST["streakPost"];
    $insert_status = $_POST["todayStatusPost"];

    $conn = new mysqli($servername, $username, $password, $dbName);

    if(!$conn) {
        die("connection failed ".mysqli_connect_error());
    }

    // $sql = "INSERT INTO homeworkApp (username, password, lastName, firstName, grade, gender) VALUES ('".$insert_username."', '".$insert_password."', '".$insert_lastName."', '".$insert_firstName."', '".$insert_grade."', '".$insert_gender."')";
    $sql = "UPDATE homeworkApp SET point=".$insert_points.", streak=".$insert_streak.", todayStatus=".$insert_status." WHERE username='".$insert_username."'";
    $result = mysqli_query($conn, $sql);

    if(!$result) echo "there was an error";
    else echo "everything is ok";

?>
