var Database = /** @class */ (function () {
    function Database() {
        this.count = 1;
        console.log("nesne uretildi");
    }
    Object.defineProperty(Database, "getInstance", {
        get: function () {
            if (this._database == null) {
                this._database = new Database();
            }
            return this._database;
        },
        enumerable: false,
        configurable: true
    });
    Database.prototype.connection = function () {
        console.log("connection");
        console.log(this.count++);
    };
    return Database;
}());
var t1 = Database.getInstance;
t1.connection();
t1.count;
var t2 = Database.getInstance;
t2.connection();
t2.count;
var t3 = Database.getInstance;
t3.connection();
t3.count;
//let t2: Database = new Database();
//let t3: Database = new Database();
//let t4: Database = new Database();
