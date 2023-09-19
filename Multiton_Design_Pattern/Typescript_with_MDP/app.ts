import { cwd } from "process";


class MailService {
    private constructor() {
        console.log("MailServices olusturuldu");
    }

    mailServices: { [key: string]: MailService } = {}

    static GetInstance(key: string) {
        if (this.mailServices[key] == null) {
            this.mailServices[key] = new MailService();
        }
        return this.mailServices[key];
    }

    private _mail: string;
    public get Mail() {
        return this._mail;
    }
    public set Mail(value: string) {
        this._mail = value;
    }
    private _username: string;
    public get Usarname() {
        return this._username;
    }
    public set Usarname(value: string) {
        this._username = value;
    }
    private _password: string;
    public get Password() {
        return this._password;
    }
    public set Password(value: string) {
        this._password = value;
    }

}


const gmail = MailService.GetInstance("gmail");
const hotmail = MailService.GetInstance("hotmail");
const outlook = MailService.GetInstance("outlook");

gmail.Mail = "asdasd";
gmail.Usarname = "asdas";
gmail.Password = "asdas"; 