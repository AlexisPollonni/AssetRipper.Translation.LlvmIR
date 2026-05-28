using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_mul2
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E4mul2Ei")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::mul2(int) const")]
	public unsafe static long Invoke([MangledName("this")] Fputil_NormalFloat_epbrnk* This, [MangledName("e")][NativeType("int")] int E)
	{
		Fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk = default(Fputil_NormalFloat_epbrnk);
		unchecked
		{
			*(int*)(&fputil_NormalFloat_epbrnk) = -1431655766;
			((short*)(&fputil_NormalFloat_epbrnk))[2] = -21846;
			((sbyte*)(&fputil_NormalFloat_epbrnk))[6] = -86;
			((sbyte*)(&fputil_NormalFloat_epbrnk))[7] = -86;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_NormalFloat_epbrnk, This, 8L, isVolatile: false);
		}
		fputil_NormalFloat_epbrnk.Exponent += E;
		return *unchecked((long*)(&fputil_NormalFloat_epbrnk));
	}
}
