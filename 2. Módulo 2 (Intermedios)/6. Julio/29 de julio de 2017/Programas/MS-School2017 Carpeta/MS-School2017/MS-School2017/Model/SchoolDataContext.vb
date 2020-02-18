Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Public Class SchoolDataContext
    Inherits DbContext
    Public Property Courses() As DbSet(Of Course)
    Public Property CourseInstructors() As DbSet(Of CourseInstructor)
    Public Property Departments() As DbSet(Of Department)
    Public Property OfficeAssignments() As DbSet(Of OfficeAssignment)
    Public Property OnlineCourses() As DbSet(Of OnlineCourse)
    Public Property OnsiteCourses() As DbSet(Of OnsiteCourse)
    Public Property Persons() As DbSet(Of Person)
    Public Property StudentGrades() As DbSet(Of StudentGrade)
    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        'modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)
    End Sub
End Class
