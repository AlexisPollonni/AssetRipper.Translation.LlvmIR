using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cprojf128
{
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* agg_result, void* x)
	{
		Struct_unhbb7 struct_unhbb = default(Struct_unhbb7);
		Struct_unhbb7 struct_unhbb2 = default(Struct_unhbb7);
		unchecked
		{
			double field_ = ((Struct_unhbb7*)x)->field_0;
			double field_2 = ((Struct_unhbb7*)x)->field_1;
			llvm_lifetime_start_p0.Invoke(32L, &struct_unhbb2);
			double* ptr = &struct_unhbb2.field_1;
			struct_unhbb2.field_0 = field_;
			*ptr = field_2;
			float128_complex_project_float128_complex_float128_complex.Invoke(&struct_unhbb, &struct_unhbb2);
			double field_3 = struct_unhbb.field_0;
			double field_4 = struct_unhbb.field_1;
			llvm_lifetime_end_p0.Invoke(32L, &struct_unhbb2);
			double* field_5 = &agg_result->field_1;
			agg_result->field_0 = field_3;
			*field_5 = field_4;
			double field_6 = agg_result->field_0;
			double field_7 = agg_result->field_1;
			double* field_8 = &agg_result->field_1;
			agg_result->field_0 = field_6;
			*field_8 = field_7;
		}
	}
}
