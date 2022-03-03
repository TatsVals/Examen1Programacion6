"use strict";
var VehiculoGrid;
(function (VehiculoGrid) {
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("¿Desea eliminar el registro seleccionado?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Vehiculo/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    VehiculoGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(VehiculoGrid || (VehiculoGrid = {}));
//# sourceMappingURL=Grid.js.map