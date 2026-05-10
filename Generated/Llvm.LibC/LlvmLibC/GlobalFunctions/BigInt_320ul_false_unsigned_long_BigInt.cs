using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt()")]
internal static partial class BigInt_320ul_false_unsigned_long_BigInt
{
	public unsafe static void Invoke(void* @this)
	{
		llvm_memset_p0_i64.Invoke(&unchecked((BigInt_76gxx6*)@this)->val.Data, 0, 40L, isVolatile: false);
	}
}
