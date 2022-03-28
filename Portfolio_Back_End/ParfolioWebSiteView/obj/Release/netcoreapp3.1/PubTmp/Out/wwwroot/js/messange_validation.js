function MessangeValidation(UserId, FullName, Email, Subject, Description) {
    if (UserId == "" || UserId == null || UserId == undefined || UserId.length == 3) {
        let locationH = location.href;
        location.href = locationH
    }

    console.log("User")

    if (FullName.length < 4) {
        $("#FullName ~ .text-danger").text("Full Name Maximum Length 3")
        return false;
    } else {
        if (FullName.length > 150) {
            $("#FullName ~ .text-danger").text("Full Name Mimum Length 150")
            return false;
        }
    }
    console.log("FullName")

    if (Subject.length < 6) {
        $("#Subject ~ .text-danger").text("Subject Maximum Length 3")
        return false;
    } else {
        if (Subject.length > 150) {
            $("#Subject ~ .text-danger").text("Subject Maximum Length 3")
            return false;
        }
    }
    console.log("Subject")

    if (Description.length < 6) {
        $("#Description ~ .text-danger").text("Description Maximum Length 3")
        return false;
    } else {
        if (Description.length > 1000) {
            $("#Description ~ .text-danger").text("Description Maximum Length 3")
            return false;
        }
    }
    console.log("Description")
    return true;
}

