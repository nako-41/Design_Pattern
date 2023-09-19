"use strict";
class Database {
    constructor() {
        this.count = 1;
        console.log("nesne uretildi");
    }
    static get getInstance() {
        if (this._database == null) {
            this._database = new Database();
        }
        return this._database;
    }
    connection() {
        console.log("connection");
        console.log(this.count++);
    }
}
let t1 = Database.getInstance;
t1.connection();
t1.count;
let t2 = Database.getInstance;
t2.connection();
t2.count;
let t3 = Database.getInstance;
t3.connection();
t3.count;
//let t2: Database = new Database();
//let t3: Database = new Database();
//let t4: Database = new Database();
//# sourceMappingURL=app.js.map