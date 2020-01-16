﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;

namespace LLBLGenPro.OrmCookbook.TypedListClasses
{
	/// <summary>Class which represents a row in the typed list 'EmployeeJoined'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="LLBLGenPro.OrmCookbook.Linq.LinqMetaData.GetEmployeeJoinedTypedList"/>.
	/// Contains the following entity definition(s):
	/// Entity: Employee. <br/>
	/// Entity: EmployeeClassification. <br/>
	/// </remarks>
	[Serializable]
	public partial class EmployeeJoinedRow : Recipes.IEmployeeDetail
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="EmployeeJoinedRow"/> class.</summary>
		public EmployeeJoinedRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the CellPhone field. Mapped onto 'Employee.CellPhone'</summary>
		public System.String CellPhone { get; set; }
		/// <summary>Gets or sets the EmployeeKey field. Mapped onto 'Employee.EmployeeKey'</summary>
		public System.Int32 EmployeeKey { get; set; }
		/// <summary>Gets or sets the FirstName field. Mapped onto 'Employee.FirstName'</summary>
		public System.String FirstName { get; set; }
		/// <summary>Gets or sets the LastName field. Mapped onto 'Employee.LastName'</summary>
		public System.String LastName { get; set; }
		/// <summary>Gets or sets the MiddleName field. Mapped onto 'Employee.MiddleName'</summary>
		public System.String MiddleName { get; set; }
		/// <summary>Gets or sets the OfficePhone field. Mapped onto 'Employee.OfficePhone'</summary>
		public System.String OfficePhone { get; set; }
		/// <summary>Gets or sets the Title field. Mapped onto 'Employee.Title'</summary>
		public System.String Title { get; set; }
		/// <summary>Gets or sets the EmployeeClassificationKey field. Mapped onto 'EmployeeClassification.EmployeeClassificationKey'</summary>
		public System.Int32 EmployeeClassificationKey { get; set; }
		/// <summary>Gets or sets the EmployeeClassificationName field. Mapped onto 'EmployeeClassification.EmployeeClassificationName'</summary>
		public System.String EmployeeClassificationName { get; set; }
		/// <summary>Gets or sets the IsEmployee field. Mapped onto 'EmployeeClassification.IsEmployee'</summary>
		public System.Boolean IsEmployee { get; set; }
		/// <summary>Gets or sets the IsExempt field. Mapped onto 'EmployeeClassification.IsExempt'</summary>
		public System.Boolean IsExempt { get; set; }
	}
}

