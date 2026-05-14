using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2ERKNS_3cpp5arrayImLm5EEE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&)")]
internal static partial class BigInt_320ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_5ul_const
{
	public unsafe static void Invoke(BigInt_76gxx6* @this, cpp_array_msasyg* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 40L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 40L, isVolatile: false);
	}
}
