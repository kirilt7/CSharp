(function () {
    var $errorMessage, $successMessage, addStudent, removeStudent, reloadStudents, resourceUrl;

    resourceUrl = 'http://localhost:3000/students';

    $successMessage = $('.messages .success');

    $errorMessage = $('.messages .error');

    addStudent = function (data) {
        return $.ajax({
            url: resourceUrl,
            type: 'POST',
            data: data,
            success: function (data) {
                $successMessage
                    .html('' + data.name + ' successfully added')
                    .show()
                    .fadeOut(2000);
                reloadStudents();
            },
            error: function (err) {
                $errorMessage
                    .html('Error happened: ' + err)
                    .show()
                    .fadeOut(2000);
            }
        });
    };

    removeStudent = function (id) {
        return $.ajax({
            url: resourceUrl +'/' + id,
            type: 'POST',
            data: {_method: 'delete'},
            success: function () {
                $successMessage
                    .html('Student successfully deleted')
                    .show()
                    .fadeOut(2000);

                reloadStudents();
            },
            error: function (err) {
                $errorMessage
                    .html('Error happened: ' + err)
                    .show()
                    .fadeOut(2000);
            }
        });
    };

    reloadStudents = function () {
        $.ajax({
            url: resourceUrl,
            type: 'GET',
            success: function (data) {
                var student, $studentsList, i, len;
                $studentsList = $('<ul/>').addClass('students-list');
                for (i = 0, len = data.students.length; i < len; i++) {
                    student = data.students[i];
                    $('<li />')
                        .addClass('student-item')
                        .append('<strong>ID:</strong> ' + student.id)
                        .append(', Name: ' + student.name)
                        .append(', Grade: ' + student.grade)
                        .appendTo($studentsList);
                }
                $('#students-container').html($studentsList);
            },
            error: function () {
                $errorMessage
                    .html("Error happened: " + err)
                    .show()
                    .fadeOut(2000);
            }
        });
    };

    $(function () {
        reloadStudents();
        $('#btn-add-student').on('click', function () {
            var student;
            student = {
                name: $('#tb-name').val(),
                grade: $('#tb-grade').val()
            };
            addStudent(student);
        });

        $('#btn-remove-student').on('click', function () {
            var id = $('#tb-id').val();
             removeStudent(id);
        });
    });

}).call(this);

//# sourceMappingURL=scripts.map