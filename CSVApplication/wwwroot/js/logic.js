
//This function capture de document and sent across the post method at controller. 

let desplegar = () => {
    var formdata = new FormData();
    var fileInput = document.getElementById('file');
    for (i = 0; i < fileInput.files.length; i++)
    {
        formdata.append('file',fileInput.files[i], fileInput.files[i]);
    }

    if (formdata != null) {
        $.ajax({
            contentType: false,
            url: '/Home/archivo',
            type: "POST",
            data: formdata,
            processData: false,
            success: function () {
            }
        });
    } else {
        console.log("Sin resultado");
    }
}

