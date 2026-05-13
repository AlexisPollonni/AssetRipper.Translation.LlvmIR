using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjf16
{
	public unsafe static InlineArray2_Half Invoke([MangledName("x.coerce")] InlineArray2_Half x)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg2 = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg3 = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg4 = default(Struct_zwcg27);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg2) = x;
			Half field_ = struct_zwcg2.field_0;
			Half field_2 = struct_zwcg2.field_1;
			Half* ptr = &struct_zwcg3.field_1;
			struct_zwcg3.field_0 = field_;
			*ptr = field_2;
			*(InlineArray2_Half*)(&struct_zwcg4) = Float16_complex_conjugate_Float16_complex_Float16_complex.Invoke(*(InlineArray2_Half*)(&struct_zwcg3));
			Half field_3 = struct_zwcg4.field_0;
			Half field_4 = struct_zwcg4.field_1;
			Half* ptr2 = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_3;
			*ptr2 = field_4;
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
