<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="EasyPayWebFormApp.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/><br/>
    <form role="form">
        <!-- Verificar contraseña del Administrador -->
        <div class="form-group">
            <label for="PassAdmin">Password Administrador</label>
            <input type="password" class="form-control" id="txtContraseña"><br/>
            <button type="submit" class="btn btn-primary" id="btnVerificar">Verificar</button>
        </div>
        <br/><br/><br/>

        <!-- Registrar nuevo empleado -->
        <!-- Numero de empleado -->
        <div class="form-group">
            <label for="NoEmpleado">Numero de Empleado</label>
            <input type="number" class="form-control" id="txtNoEmpleado">
        </div>

        <!-- Nuevo Usuario -->
        <div class="form-group">
            <label for="Usuario">Nuevo Usuario</label>
            <input type="text" class="form-control" id="txtUsuario" placeholder="Introduce tu Numero de Empleado">
        </div>

        <!-- Nuevo Password -->
        <div class="form-group">
            <label for="NuevaContrasena">Nuevo Password</label>
            <input type="password" class="form-control" id="txtContrasena" placeholder="Introduce tu Nuevo Password">
        </div>

         <!-- Fecha -->
        <div class="form-group">
            <label for="Fecha">Fecha</label>
            <input type="date" class="form-control" id="txtFecha">
        </div>

        <!-- Botones -->
        <div class="form-group">
            <button type="submit" class="btn btn-success">Registrar</button>
            <button type="submit" class="btn btn-danger">Regresar</button>
        </div>
    </form>
</asp:Content>
