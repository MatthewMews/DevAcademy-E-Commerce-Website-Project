import * as tslib_1 from "tslib";
import { Pipe } from '@angular/core';
var UpdateRowsPipe = /** @class */ (function () {
    function UpdateRowsPipe() {
    }
    UpdateRowsPipe.prototype.transform = function (value, perRow) {
        var rows = [];
        for (var i = 0; i < value.length; i += perRow) {
            rows.push(value.slice(i, i + perRow));
        }
        return rows;
    };
    UpdateRowsPipe = tslib_1.__decorate([
        Pipe({
            name: 'updateRows'
        })
    ], UpdateRowsPipe);
    return UpdateRowsPipe;
}());
export { UpdateRowsPipe };
//# sourceMappingURL=updaterows.pipe.js.map