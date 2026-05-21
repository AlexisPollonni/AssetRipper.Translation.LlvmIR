using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_BigInt_128ul_false_unsigned_long_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::value() &")]
	public unsafe static anon_izyfb7* Invoke(void* @this)
	{
		return unchecked((anon_izyfb7*)(&((cpp_optional_neprgb*)@this)->storage.field));
	}
}
