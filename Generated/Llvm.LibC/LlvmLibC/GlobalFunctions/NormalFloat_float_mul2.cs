using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfE4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::mul2(int) const")]
	public unsafe static Struct_8myw6y Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* This, [MangledName("e")][NativeType("int")] int E)
	{
		Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv llvm_libc_20_1_2_fputil_NormalFloat_phu2qv = default(Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv) = -1431655766;
			((int*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv))[1] = -1431655766;
			((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv))[8] = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv) + 9;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_phu2qv, This, 12L, isVolatile: false);
		}
		llvm_libc_20_1_2_fputil_NormalFloat_phu2qv.Exponent += E;
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &llvm_libc_20_1_2_fputil_NormalFloat_phu2qv, 12L, isVolatile: false);
		return result;
	}
}
