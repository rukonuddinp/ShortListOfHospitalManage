function AddNCD() {
    $('#ncdSelect option:selected').each(function () {
        $(this).clone().appendTo('#selectedNCDs');
        $(this).prop('disabled', true); // Disable the selected option
    });
}

function RemoveNCD() {
    $('#selectedNCDs option:selected').each(function () {
        var value = $(this).val();
        $('#ncdSelect option').filter(function () {
            return $(this).val() == value;
        }).prop('disabled', false); // Re-enable the option in the original select
        $(this).remove(); // Remove the option from the selected list
    });
}

function AddAllargy() {
    $('#allargySelect option:selected').each(function () {
        $(this).clone().appendTo('#selectedAllergy');
        $(this).prop('disabled', true); // Disable the selected option
    });
}

function RemoveAllargy() {
    $('#selectedAllergy option:selected').each(function () {
        var value = $(this).val();
        $('#allargySelect option').filter(function () {
            return $(this).val() == value;
        }).prop('disabled', false); // Re-enable the option in the original select
        $(this).remove(); // Remove the option from the selected list
    });
}



function submitForm() {
    debugger;
    var selectedNCDs = [];
    $('#selectedNCDs option').each(function () {
        selectedNCDs.push($(this).val());
    });

    var selectedAllergies = [];
    $('#selectedAllergy option').each(function () {
        selectedAllergies.push($(this).val());
    });

   
    var formData = $('#patientForm').serializeArray();
    var data = {};

    // Convert the formData array to an object for easier manipulation
    formData.forEach(function (item) {
        data[item.name] = item.value;
    });


    // Add selectedNCDs and selectedAllergies to the data object
    data.selectedNCDs = selectedNCDs;
    data.selectedAllergies = selectedAllergies;

    // Validation
    if (!data.PatientName || data.PatientName.trim() === "") {
        return toastr.error("Please enter the patient's name.");
    }
    if (!data.DiseaseFK_Id || data.DiseaseFK_Id.trim() === "") {
        return toastr.error("Please select a disease.");
    }
    if (data.EpilepsyVal === undefined || data.EpilepsyVal.trim() === "") {
        return toastr.error("Please select an epilepsy status.");
    }
    if (selectedAllergies.length === 0) {
        return toastr.error("Please select at least one allergy.");
    }

    $.ajax({
        url: "/Patient/Create",
        type: 'POST',
        data: JSON.stringify(data), // Send the data as JSON
        contentType: "application/json; charset=utf-8", // Specify JSON content type
        success: function (response) {
            if (response.success) {
                toastr.success(response.message);
                setTimeout(function () {
                    $('#patientForm')[0].reset(); // Clear the form fields
                    $('#selectedNCDs').empty(); // Clear the selected NCDs
                    $('#selectedAllergy').empty(); // Clear the selected allergies
                    location.reload();
                }, 2000); // Wait for 2 seconds before reloading the page
            } else {
                toastr.success(response.message);
                setTimeout(function () {
                    location.reload();
                }, 2000); // Wait for 2 seconds before reloading the page
            }
        },
        error: function () {
            alert('An error occurred while sending the request.');
        }
    });
}

