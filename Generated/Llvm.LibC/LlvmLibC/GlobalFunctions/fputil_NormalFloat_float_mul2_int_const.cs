using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfE4mul2Ei")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::mul2(int) const")]
internal static partial class fputil_NormalFloat_float_mul2_int_const
{
	public unsafe static Struct_8myw6y Invoke(fputil_NormalFloat_phu2qv* @this, int e)
	{
		fputil_NormalFloat_phu2qv fputil_NormalFloat_phu2qv2 = default(fputil_NormalFloat_phu2qv);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(int*)(&fputil_NormalFloat_phu2qv2) = -1431655766;
			((int*)(&fputil_NormalFloat_phu2qv2))[1] = -1431655766;
			((sbyte*)(&fputil_NormalFloat_phu2qv2))[8] = -86;
			sbyte* ptr = (sbyte*)(&fputil_NormalFloat_phu2qv2) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_NormalFloat_phu2qv2, @this, 12L, isVolatile: false);
		}
		fputil_NormalFloat_phu2qv2.exponent += e;
		llvm_memcpy_p0_p0_i64.Invoke(&result, &fputil_NormalFloat_phu2qv2, 12L, isVolatile: false);
		return result;
	}
}
