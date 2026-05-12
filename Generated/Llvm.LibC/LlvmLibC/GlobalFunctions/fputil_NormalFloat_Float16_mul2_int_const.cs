using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E4mul2Ei")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::mul2(int) const")]
internal static partial class fputil_NormalFloat_Float16_mul2_int_const
{
	public unsafe static long Invoke(fputil_NormalFloat_epbrnk* @this, int e)
	{
		fputil_NormalFloat_epbrnk fputil_NormalFloat_epbrnk2 = default(fputil_NormalFloat_epbrnk);
		unchecked
		{
			*(int*)(&fputil_NormalFloat_epbrnk2) = -1431655766;
			((short*)(&fputil_NormalFloat_epbrnk2))[2] = -21846;
			((sbyte*)(&fputil_NormalFloat_epbrnk2))[6] = -86;
			((sbyte*)(&fputil_NormalFloat_epbrnk2))[7] = -86;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_NormalFloat_epbrnk2, @this, 8L, isVolatile: false);
		}
		fputil_NormalFloat_epbrnk2.exponent += e;
		return *unchecked((long*)(&fputil_NormalFloat_epbrnk2));
	}
}
