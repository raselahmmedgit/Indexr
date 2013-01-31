//-----------------------------------------------------
//start Add, Edit, Delete - Success Funtion
// Add Index Success Function
function AddIndexrSuccess() {
    alert("AddIndexrSuccess");
    if ($("#updateTargetId").html() == "True") {

        //now we can close the dialog
        $('#addIndexrDialog').dialog('close');
        //twitter type notification
        $('#commonMessage').html("Indexr Added.");
        $('#commonMessage').delay(400).slideDown(400).delay(3000).slideUp(400);


    }
    else {
        //show message in popup
        $("#addIndexrMess").show();
    }
}

// Edit Index Success Function
function EditIndexrSuccess() {
    if ($("#updateTargetId").html() == "True") {

        //now we can close the dialog
        $('#editIndexrDialog').dialog('close');
        //twitter type notification
        $('#commonMessage').html("Indexr Updated.");
        $('#commonMessage').delay(400).slideDown(400).delay(3000).slideUp(400);


    }
    else {
        //show message in popup
        $("#editIndexrMess").show();
    }
}

// Delete Index Success Function
function DeleteIndexrSuccess() {
    if ($("#updateTargetId").html() == "True") {

        //now we can close the dialog
        $('#deleteIndexrDailog').dialog('close');
        //twitter type notification
        $('#commonMessage').html("Indexr deleted");
        $('#commonMessage').delay(400).slideDown(400).delay(3000).slideUp(400);


    }
    else {
        //show message in popup
        $("#deleteIndexrMess").show();
    }
}
//end Add, Edit, Delete - Success Funtion
//-----------------------------------------------------

//-----------------------------------------------------
//start Add, Edit, Delete - Success Common Funtion
function AjaxSuccess(updateTargetId, dailogId, commonMessageId, commonMessage) {

    var _updateTargetId = "#" + updateTargetId;
    var _dailogID = "#" + dailogId;
    var _commonMessageId = "#" + commonMessageId;
    var _commonMessage = commonMessage;

    if ($(_updateTargetId).html() == "True") {

        //now we can close the dialog
        $(_dailogID).dialog('close');
        //twitter type notification
        $(_commonMessageId).html(_commonMessage);
        $(_commonMessageId).delay(400).slideDown(400).delay(3000).slideUp(400);


    }
    else {
        //show message in popup
        $(_updateTargetId).show();
    }
}
//end Add, Edit, Delete - Success Common Funtion
//-----------------------------------------------------

$(document).ready(function () {

    //-------------------------------------------------------
    //start Add, Edit, Delete - Dialog, Click Event

    $("#addIndexrDialog").dialog({
        autoOpen: false,
        width: 680,
        resizable: false,
        modal: true,
        buttons: {
            "Add": function () {
                //make sure there is nothing on the message before we continue 
                $("#updateTargetId").html('');
                $("#addIndexrForm").submit();
            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
    });

    //add Index
    $('#lnkAddIndexr').click(function () {

        //change the title of the dialog
        var linkObj = $(this);
        var dialogDiv = $('#addIndexrDialog');
        var viewUrl = linkObj.attr('href');

        $.get(viewUrl, function (data) {
            dialogDiv.html(data);
            //validation
            var $form = $("#addIndexrForm");
            // Unbind existing validation
            $form.unbind();
            $form.data("validator", null);
            // Check document for changes
            $.validator.unobtrusive.parse(document);
            // Re add validation with changes
            $form.validate($form.data("unobtrusiveValidation").options);
            //open dialog
            dialogDiv.dialog('open');
        });
        return false;

    });

    //edit Index
    $("#editIndexrDialog").dialog({
        autoOpen: false,
        width: 680,
        resizable: false,
        closeOnEscape: false,
        modal: true,
        close: function (event, ui) {
            $(".popover").hide();
        },
        buttons: {
            "Edit": function () {
                //make sure there is nothing on the message before we continue   
                $("#updateTargetId").html('');
                $("#editIndexrForm").submit();
            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }

    });

    $('#indexrGrid a.lnkEditIndexr').live('click', function () {

        //change the title of the dialog
        var linkObj = $(this);
        var dialogDiv = $('#editIndexrDialog');
        var viewUrl = linkObj.attr('href');
        $.get(viewUrl, function (data) {
            dialogDiv.html(data);
            //validation
            var $form = $("#editIndexrForm");
            // Unbind existing validation
            $form.unbind();
            $form.data("validator", null);
            // Check document for changes
            $.validator.unobtrusive.parse(document);
            // Re add validation with changes
            $form.validate($form.data("unobtrusiveValidation").options);
            //open dialog
            dialogDiv.dialog('open');
        });
        return false;

    });

    //delete Index
    $("#deleteIndexrDailog").dialog({
        autoOpen: false,
        width: 450,
        resizable: false,
        modal: true,
        buttons: {
            "Yes": function () {
                //make sure there is nothing on the message before we continue                         
                $("#updateTargetId").html('');
                $("#deleteIndexrForm").submit();
            },
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
    });

    $('#indexrGrid a.lnkDeleteIndexr').live('click', function () {

        //change the title of the dialog
        var linkObj = $(this);
        var dialogDiv = $('#deleteIndexrDailog');
        var viewUrl = linkObj.attr('href');
        $.get(viewUrl, function (data) {
            dialogDiv.html(data);
            //validation
            var $form = $("#deleteIndexrForm");
            // Unbind existing validation
            $form.unbind();
            $form.data("validator", null);
            // Check document for changes
            $.validator.unobtrusive.parse(document);
            // Re add validation with changes
            $form.validate($form.data("unobtrusiveValidation").options);
            //open dialog
            dialogDiv.dialog('open');
        });
        return false;

    });

    //For details Index
    $("#detailsIndexrDialog").dialog({
        autoOpen: false,
        width: 680,
        resizable: false,
        modal: true,
        buttons: {
            "Cancel": function () {
                $(this).dialog("close");
            }
        }
    });

    $('#indexrGrid td a.lnkDetailsIndexr').live('click', function () {

        var linkObj = $(this);
        var dialogDiv = $('#detailsIndexrDialog');
        var viewUrl = linkObj.attr('href');
        $.get(viewUrl, function (data) {
            dialogDiv.html(data);
            dialogDiv.dialog('open');
        });
        return false;

    });

    //end Add, Edit, Delete - Dialog, Click Event
    //-------------------------------------------------------

});