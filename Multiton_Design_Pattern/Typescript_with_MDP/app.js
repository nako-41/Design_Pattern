"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var MailService = /** @class */ (function () {
    function MailService() {
        this.mailServices = {};
        console.log("MailServices olusturuldu");
    }
    MailService.GetInstance = function (key) {
        if (this.mailServices[key] == null) {
            this.mailServices[key] = new MailService();
        }
        return this.mailServices[key];
    };
    Object.defineProperty(MailService.prototype, "Mail", {
        get: function () {
            return this._mail;
        },
        set: function (value) {
            this._mail = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(MailService.prototype, "Usarname", {
        get: function () {
            return this._username;
        },
        set: function (value) {
            this._username = value;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(MailService.prototype, "Password", {
        get: function () {
            return this._password;
        },
        set: function (value) {
            this._password = value;
        },
        enumerable: false,
        configurable: true
    });
    return MailService;
}());
var gmail = MailService.GetInstance("gmail");
var hotmail = MailService.GetInstance("hotmail");
var outlook = MailService.GetInstance("outlook");
gmail.Mail = "asdasd";
gmail.Usarname = "asdas";
gmail.Password = "asdas";
