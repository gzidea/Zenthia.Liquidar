Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class ModeloSeguridad
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ModeloSeguridad")
    End Sub

    Public Overridable Property Modulos As DbSet(Of Modulos)
    Public Overridable Property Operaciones As DbSet(Of Operaciones)
    Public Overridable Property Roles As DbSet(Of Roles)
    Public Overridable Property Roles_Modulos_Operaciones As DbSet(Of Roles_Modulos_Operaciones)
    Public Overridable Property Usuarios As DbSet(Of Usuarios)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Modulos)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Modulos)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Modulos) _
            .HasForeignKey(Function(e) e.IdModulo) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Operaciones)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Operaciones)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Operaciones) _
            .HasForeignKey(Function(e) e.IdOperador) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Roles)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Roles)() _
            .HasMany(Function(e) e.Roles_Modulos_Operaciones) _
            .WithRequired(Function(e) e.Roles) _
            .HasForeignKey(Function(e) e.IdRol) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Roles)() _
            .HasMany(Function(e) e.Usuarios) _
            .WithOptional(Function(e) e.Roles) _
            .HasForeignKey(Function(e) e.IdRol)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Login) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Email) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Usuarios)() _
            .Property(Function(e) e.Password) _
            .IsUnicode(False)
    End Sub
End Class
