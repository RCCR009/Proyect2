
function vCustomers() {

	this.tblCustomersId = 'tblCustomers';
	this.service = 'customer';
	this.ctrlActions = new ControlActions();
	this.columns = "Id,Name,LastName,Age";

	this.RetrieveAll = function () {
		this.ctrlActions.FillTable(this.service, this.tblCustomersId); 		
	}

	this.Create = function () {
			
	}

	this.Update=function(){

	}

	this.BindFields = function (data) {
		this.ctrlActions.BindFields('frmEdition', data);
		//console.log(data);
		//$('#frmEdition *').filter(':input').each(function (input) {
		//	var columnDataName = $(this).attr("ColumnDataName");
		//	this.value = data[columnDataName];
		//});
	}

}

//ON DOCUMENT READY
$(document).ready(function () {

	var vcustomer = new vCustomers();
	vcustomer.RetrieveAll();

});

