using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_BigInt_128ul_false_unsigned_long_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm128ELb0EmEEE15OptionalStorageIS3_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>>::OptionalStorage<__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>, false>::OptionalStorage()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Cpp_optional_BigInt_128_false_OptionalStorage*)This)->field) = 0;
			((Cpp_optional_BigInt_128_false_OptionalStorage*)This)->In_use = 0;
		}
	}
}
