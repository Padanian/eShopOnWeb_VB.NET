﻿Namespace Areas.Identity.Pages.Account

    Partial Public Class LoginModel
        Private Function GetVbXml() As XElement
            Return _
<zml xmlns:z="zml">
    <z:model type="LoginModel"/>

    <div class="container account-login-container">
        <h2><z:title/></h2>
        <div class="row">
            <div class="col-md-12">
                <section>
                    <form method="post">
                        <hr/>
                        <div asp-validation-summary="All" class="text-danger"></div>
                        <div class="form-group">
                            <label asp-for="Input.Email"></label>
                            <input asp-for="Input.Email" class="form-control"/>
                            <span asp-validation-for="Input.Email" class="text-danger"></span>
                        </div>
                        <div class="form-group">
                            <label asp-for="Input.Password"></label>
                            <input asp-for="Input.Password" class="form-control"/>
                            <span asp-validation-for="Input.Password" class="text-danger"></span>
                        </div>
                        <div class="form-group">
                            <div class="checkbox">
                                <label asp-for="Input.RememberMe">
                                    <input asp-for="Input.RememberMe"/>
                                    <z:displaynamefor var="m" return="m.Input.RememberMe"/>
                                </label>
                            </div>
                        </div>
                        <div class="form-group">
                            <button type="submit" class="btn btn-default">Log in</button>
                        </div>
                        <div class="form-group">
                            <p>
                                <a asp-page="./ForgotPassword">Forgot your password?</a>
                            </p>
                            <p>
                                <a asp-page="./Register" asp-route-returnUrl="@Model.ReturnUrl">Register as a new user</a>
                            </p>
                        </div>
                        <p>
                        Note that for demo purposes you don't need to register and can login with these credentials:
                    </p>
                        <p>
                        User:     <b>demouser@microsoft.com</b>
                        </p>
                        <p>
                        Password: <b>Pass@word1</b>
                        </p>
                    </form>
                </section>
            </div>
        </div>
    </div>

    <z:section name="Scripts">
        <partial name="_ValidationScriptsPartial"/>
    </z:section>

</zml>
        End Function
    End Class
End Namespace