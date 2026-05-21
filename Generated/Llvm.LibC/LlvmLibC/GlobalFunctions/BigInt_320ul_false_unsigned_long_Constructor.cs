using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2ERKNS_3cpp5arrayImLm5EEE")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&)")]
	public unsafe static void Invoke(BigInt_76gxx6* @this, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> const&")] cpp_array_msasyg* words)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 40L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&@this->val, words, 40L, isVolatile: false);
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt()")]
	public unsafe static void Invoke(BigInt_76gxx6* @this)
	{
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 40L, isVolatile: false);
	}
}
