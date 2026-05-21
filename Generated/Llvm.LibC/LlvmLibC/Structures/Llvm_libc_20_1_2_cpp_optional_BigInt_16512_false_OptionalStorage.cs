using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2072)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_6BigIntILm16512ELb0EmEEE15OptionalStorageIS3_Lb0EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512, false>>::OptionalStorage")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::BigInt<16512, false>>::OptionalStorage")]
public partial struct Llvm_libc_20_1_2_cpp_optional_BigInt_16512_false_OptionalStorage
{
	[FieldOffset(0)]
	public Anon_5rrs7e field;

	[FieldOffset(2064)]
	public sbyte In_use;

	[FieldOffset(2065)]
	public InlineArray7_SByte field_2;
}
