using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator[](unsigned long)")]
[CleanName("BigInt_320ul_false_unsigned_long_operator_unsigned_long")]
internal static partial class BigInt_320ul_false_unsigned_long_operator_unsigned_long_znxjv9
{
	public unsafe static void* Invoke(BigInt_76gxx6* @this, long i)
	{
		return cpp_array_unsigned_long_5ul_operator_unsigned_long.Invoke(&@this->val, i);
	}
}
