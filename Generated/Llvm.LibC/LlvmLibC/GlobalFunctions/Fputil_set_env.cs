using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_set_env
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7set_envEPK6fenv_t")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::set_env(fenv_t const*)")]
	public unsafe static int Invoke([MangledName("envp")][NativeType("fenv_t const*")] void* Envp)
	{
		Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor llvm_libc_20_1_2_fputil_internal_X87StateDescriptor = default(Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		int i = 0;
		int num = 0;
		void* ptr = null;
		int j = 0;
		Llvm_lifetime_start_p0.Invoke(28L, &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor) = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[1] = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[2] = -21846;
			((short*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor))[3] = -21846;
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor) + 8;
			*(int*)ptr2 = -1431655766;
			((int*)ptr2)[1] = -1431655766;
			((int*)ptr2)[2] = -1431655766;
			((int*)ptr2)[3] = -1431655766;
			((int*)ptr2)[4] = -1431655766;
			Internal_get_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			int result;
			if (Envp == (void*)(-1L))
			{
				short* ptr3 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Status_word;
				*ptr3 = (short)((ushort)(*ptr3) & -64);
				Llvm_lifetime_start_p0.Invoke(4L, &i);
				for (i = 0; i < 5; i = checked(i + 1))
				{
					Unsafe.As<InlineArray5_Int32, int>(ref Unsafe.AddByteOffset(ref llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.field, (nint)i * (nint)4)) = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &i);
				short* ptr4 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Control_word;
				*ptr4 = (short)((ushort)(*ptr4) | 0x3F);
				short* ptr5 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Control_word;
				*ptr5 = (short)((ushort)(*ptr5) & -3073);
				short* ptr6 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Control_word;
				*ptr6 = (short)((ushort)(*ptr6) | 0x300);
				Internal_write_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = Internal_get_mxcsr.Invoke();
				num &= -64;
				num &= -65;
				num |= 0x1F80;
				num &= -24577;
				num &= -32769;
				Internal_write_mxcsr.Invoke(num);
				result = 0;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &ptr);
				ptr = Envp;
				short* ptr7 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Status_word;
				*ptr7 = (short)((ushort)(*ptr7) & -64);
				int num2 = (ushort)((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->X87_status.Status_word & 0x3F;
				short* ptr8 = &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Status_word;
				*ptr8 = (short)((ushort)(*ptr8) | num2);
				Llvm_lifetime_start_p0.Invoke(4L, &j);
				for (j = 0; j < 5; j = checked(j + 1))
				{
					int num3 = ((int*)(&((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->X87_status.field))[j];
					Unsafe.As<InlineArray5_Int32, int>(ref Unsafe.AddByteOffset(ref llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.field, (nint)j * (nint)4)) = num3;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &j);
				llvm_libc_20_1_2_fputil_internal_X87StateDescriptor.Control_word = ((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->X87_status.Control_word;
				Internal_write_x87_state_descriptor.Invoke(&llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
				Internal_write_mxcsr.Invoke(((Llvm_libc_20_1_2_fputil_internal_FPState*)ptr)->Mxcsr);
				result = 0;
				Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			}
			Llvm_lifetime_end_p0.Invoke(28L, &llvm_libc_20_1_2_fputil_internal_X87StateDescriptor);
			return result;
		}
	}
}
