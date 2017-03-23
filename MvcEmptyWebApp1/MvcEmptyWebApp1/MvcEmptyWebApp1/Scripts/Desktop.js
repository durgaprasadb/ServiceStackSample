function DesktopCreate() {
    $.ajax({
        type: "POST",
        async: true,
        url: "/api/desktop",
        dataType: "json",
        data: {
            UUID: 'UUID',
            NameSpace: "NameSpace"
        },
        success: function (json, textStatus) {
            if (json) {
            }
        }
    });
}