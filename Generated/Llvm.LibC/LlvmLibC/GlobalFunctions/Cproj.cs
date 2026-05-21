using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cproj
{
	[MangledName("cproj")]
	[DemangledName("cproj")]
	public unsafe static Struct_4ydhja Invoke([MangledName("x.coerce0")] double X, [MangledName("x.coerce1")] double X_coerce1)
	{
		Struct_4ydhja result = default(Struct_4ydhja);
		Struct_4ydhja struct_4ydhja = default(Struct_4ydhja);
		Struct_4ydhja struct_4ydhja2 = default(Struct_4ydhja);
		struct_4ydhja.field_0 = X;
		struct_4ydhja.field_1 = X_coerce1;
		double field_ = struct_4ydhja.field_0;
		double field_2 = struct_4ydhja.field_1;
		double* ptr = &struct_4ydhja2.field_1;
		struct_4ydhja2.field_0 = field_;
		*ptr = field_2;
		Struct_4ydhja struct_4ydhja3 = Llvm_libc_20_1_2_project_double_complex.Invoke(struct_4ydhja2.field_0, struct_4ydhja2.field_1);
		Struct_4ydhja struct_4ydhja4 = struct_4ydhja3;
		double field_3 = struct_4ydhja4.field_0;
		Struct_4ydhja struct_4ydhja5 = struct_4ydhja3;
		double field_4 = struct_4ydhja5.field_1;
		double* ptr2 = &result.field_1;
		result.field_0 = field_3;
		*ptr2 = field_4;
		return result;
	}
}
