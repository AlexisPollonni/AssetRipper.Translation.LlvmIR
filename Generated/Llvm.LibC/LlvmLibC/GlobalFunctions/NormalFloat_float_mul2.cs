using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfE4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::mul2(int) const")]
	public unsafe static Struct_8myw6y Invoke([MangledName("this")] Fputil_NormalFloat_phu2qv* This, [MangledName("e")][NativeType("int")] int E)
	{
		Fputil_NormalFloat_phu2qv fputil_NormalFloat_phu2qv = default(Fputil_NormalFloat_phu2qv);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(int*)(&fputil_NormalFloat_phu2qv) = -1431655766;
			((int*)(&fputil_NormalFloat_phu2qv))[1] = -1431655766;
			((sbyte*)(&fputil_NormalFloat_phu2qv))[8] = -86;
			sbyte* ptr = (sbyte*)(&fputil_NormalFloat_phu2qv) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_NormalFloat_phu2qv, This, 12L, isVolatile: false);
		}
		fputil_NormalFloat_phu2qv.Exponent += E;
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &fputil_NormalFloat_phu2qv, 12L, isVolatile: false);
		return result;
	}
}
