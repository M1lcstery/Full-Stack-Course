function submitForm(event) {
    event.preventDefault(); // Prevent the default form submission
  
    // Retrieve the input values
    var name = document.getElementById('name').value;
    var surname = document.getElementById('surname').value;
    var age = document.getElementById('age').value;
  
    // Create a new row in the table
    var table = document.getElementById('data-table');
    var newRow = table.insertRow();
  
    // Insert cells with the input values into the new row
    var nameCell = newRow.insertCell();
    nameCell.textContent = name;
  
    var surnameCell = newRow.insertCell();
    surnameCell.textContent = surname;
  
    var ageCell = newRow.insertCell();
    ageCell.textContent = age;
  
    // Clear the input values
    document.getElementById('name').value = '';
    document.getElementById('surname').value = '';
    document.getElementById('age').value = '';
  }
  