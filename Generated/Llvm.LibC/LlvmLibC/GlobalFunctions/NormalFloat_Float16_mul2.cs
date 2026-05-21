using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::mul2(int) const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk* This, [MangledName("e")][NativeType("int")] int E)
	{
		Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk llvm_libc_20_1_2_fputil_NormalFloat_epbrnk = default(Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk) = -1431655766;
			((short*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[2] = -21846;
			((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[6] = -86;
			((sbyte*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk))[7] = -86;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk, This, 8L, isVolatile: false);
		}
		llvm_libc_20_1_2_fputil_NormalFloat_epbrnk.Exponent += E;
		return *unchecked((long*)(&llvm_libc_20_1_2_fputil_NormalFloat_epbrnk));
	}
}
