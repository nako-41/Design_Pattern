


class Database {
   private constructor() {
        console.log("nesne uretildi");
    }
    private static _database: Database;

    static get getInstance() {
        if (this._database == null) {
            this._database = new Database();
        }
        return this._database; 
    }

    count: number = 1;
    connection() {
        console.log("connection");
        console.log(this.count++);
    }
}


let t1: Database = Database.getInstance;
t1.connection();
t1.count;

let t2: Database = Database.getInstance;
t2.connection();
t2.count;

let t3: Database = Database.getInstance;
t3.connection();
t3.count;


//let t2: Database = new Database();
//let t3: Database = new Database();
//let t4: Database = new Database();