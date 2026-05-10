using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjl
{
	public unsafe static Struct_29m54m Invoke(void* x)
	{
		Struct_29m54m result = default(Struct_29m54m);
		Struct_29m54m struct_29m54m = default(Struct_29m54m);
		unchecked
		{
			double field_ = ((Struct_29m54m*)x)->field_0;
			double field_2 = ((Struct_29m54m*)x)->field_1;
			llvm_lifetime_start_p0.Invoke(32L, &struct_29m54m);
			double* ptr = &struct_29m54m.field_1;
			struct_29m54m.field_0 = field_;
			*ptr = field_2;
			Struct_29m54m struct_29m54m2 = long_double_complex_conjugate_long_double_complex_long_double_complex.Invoke(&struct_29m54m);
			Struct_29m54m struct_29m54m3 = struct_29m54m2;
			double field_3 = struct_29m54m3.field_0;
			Struct_29m54m struct_29m54m4 = struct_29m54m2;
			double field_4 = struct_29m54m4.field_1;
			llvm_lifetime_end_p0.Invoke(32L, &struct_29m54m);
			double* ptr2 = &result.field_1;
			result.field_0 = field_3;
			*ptr2 = field_4;
			return result;
		}
	}
}
