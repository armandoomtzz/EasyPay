<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EasyPayWebFormApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <form role="form">
        <!-- Numero de Empleado -->
        <div class="form-group">
            <label for="NoEmpleado">No. Empleado</label>
            <input type="text" class="form-control" id="txtNoEmpleado" placeholder="Introduce tu Numero de Empleado">
        </div>

        <!-- Usuario -->
        <div class="form-group">
            <label for="Usuario">Usuario</label>
            <input type="text" class="form-control" id="txtUsuario" placeholder="Introduce tu Usuario">
        </div>

        <!-- Contraseña -->
        <div class="form-group">
            <label for="Contrasena">Password</label>
            <input type="password" class="form-control" id="txtContraseña">
        </div>

        <!-- Botones -->
        <div class="form-group">
            <button type="submit" class="btn btn-primary" id="bntRegistrar">Registrar</button>
            <button type="submit" class="btn btn-warning" id="btnVerificar">Vefificar</button>
            <button type="submit" class="btn btn-success" id="btnConectar">Conectar</button>
        </div>
    </form>
</asp:Content>
