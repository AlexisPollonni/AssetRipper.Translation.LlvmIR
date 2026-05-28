using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_clear_except
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12clear_exceptEi")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::clear_except(int)")]
	public unsafe static int Invoke([MangledName("excepts")][NativeType("int")] int Excepts)
	{
		Fputil_internal_X87StateDescriptor fputil_internal_X87StateDescriptor = default(Fputil_internal_X87StateDescriptor);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(28L, &fputil_internal_X87StateDescriptor);
		unchecked
		{
			*(short*)(&fputil_internal_X87StateDescriptor) = -21846;
			((short*)(&fputil_internal_X87StateDescriptor))[1] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor))[2] = -21846;
			((short*)(&fputil_internal_X87StateDescriptor))[3] = -21846;
			sbyte* ptr = (sbyte*)(&fputil_internal_X87StateDescriptor) + 8;
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)ptr)[2] = -1431655766;
			((int*)ptr)[3] = -1431655766;
			((int*)ptr)[4] = -1431655766;
			Internal_get_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor);
			int num2 = (ushort)(short)((ushort)Internal_get_status_value_for_except.Invoke(Excepts) ^ -1);
			short* ptr2 = &fputil_internal_X87StateDescriptor.Status_word;
			*ptr2 = (short)((ushort)(*ptr2) & num2);
			Internal_write_x87_state_descriptor.Invoke(&fputil_internal_X87StateDescriptor);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Internal_get_mxcsr.Invoke();
			int num3 = (ushort)Internal_get_status_value_for_except.Invoke(Excepts) ^ -1;
			num &= num3;
			Internal_write_mxcsr.Invoke(num);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(28L, &fputil_internal_X87StateDescriptor);
			return 0;
		}
	}
}
