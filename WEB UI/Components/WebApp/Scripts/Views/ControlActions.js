
function ControlActions() {

	this.URL_API = "http://localhost:57056/api/";

	this.GetUrlApiService = function (service) {
		return this.URL_API + service;
	}

	this.GetTableColumsDataName = function (tableId) {
		var val = $('#' + tableId).attr("ColumnsDataName");

		return val;
	}

	this.FillTable = function (service, tableId) {

		columns = this.GetTableColumsDataName(tableId).split(',');
		var arrayColumnsData = [];


		$.each(columns, function (index, value) {
			var obj = {};
			obj.data = value;
			arrayColumnsData.push(obj);
		});

		$('#' + tableId).DataTable({
			"processing": true,
			"ajax": {
				"url": this.GetUrlApiService(service),
				dataSrc: 'Data'
			},
			"columns": arrayColumnsData
		});
	}

	this.GetSelectedRow = function () {
		var data = sessionStorage.getItem(tableId + '_selected');

		return data;
	};

	this.BindFields = function (formId, data) {
		console.log(data);
		$('#' + formId +' *').filter(':input').each(function (input) {
			var columnDataName = $(this).attr("ColumnDataName");
			this.value = data[columnDataName];
		});
	}
}
