using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjf
{
	public unsafe static InlineArray2_Single Invoke([MangledName("x.coerce")] InlineArray2_Single x)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj2 = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj3 = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj4 = default(Struct_kh2xpj);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj2) = x;
			float field_ = struct_kh2xpj2.field_0;
			float field_2 = struct_kh2xpj2.field_1;
			float* ptr = &struct_kh2xpj3.field_1;
			struct_kh2xpj3.field_0 = field_;
			*ptr = field_2;
			*(InlineArray2_Single*)(&struct_kh2xpj4) = float_complex_conjugate_float_complex_float_complex.Invoke(*(InlineArray2_Single*)(&struct_kh2xpj3));
			float field_3 = struct_kh2xpj4.field_0;
			float field_4 = struct_kh2xpj4.field_1;
			float* ptr2 = &struct_kh2xpj.field_1;
			struct_kh2xpj.field_0 = field_3;
			*ptr2 = field_4;
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
